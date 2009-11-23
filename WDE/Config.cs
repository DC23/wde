using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace jd.Helper.XXApplication.Configuration
{
   /// <summary>
   /// Verwaltet eine Einstellung
   /// </summary>
   public class Setting
   {
      /// <summary>
      /// Der Name der Einstellung
      /// </summary>
      public string Name;

      /// <summary>
      /// Der Wert der Einstellung
      /// </summary>
      public string Value;

      /// <summary>
      /// Der Defaultwert für das Lesen
      /// </summary>
      public string DefaultValue;

      /// <summary>
      /// Gibt an, ob die Einstellung
      /// in der Datei gefunden wurde
      /// </summary>
      public bool WasInFile;

      /// <summary>
      /// Konstruktor
      /// </summary>
      /// <param name="name">Der Name der Einstellung</param>
      /// <param name="defaultValue">Der Defaultwert für das Lesen</param>
      public Setting(string name, string defaultValue)
      {
         this.Name = name;
         this.DefaultValue = defaultValue;
      }
   }

   /// <summary>
   /// Auflistung zum Speichern mehrerer Einstellungen
   /// </summary>
   public class Settings : Dictionary<string, Setting>
   {
      /// <summary>
      /// Fügt der Auflistung eine neue Einstellung hinzu
      /// </summary>
      /// <param name="settingName">Der Name der Einstellung</param>
      /// <param name="defaultValue">Der Defaultwert für das Lesen</param>
      public void Add(string settingName, string defaultValue)
      {
         this.Add(settingName,
            new Setting(settingName, defaultValue));
      }

   }

   /// <summary>
   /// Verwaltet eine Einstellungs-Sektion
   /// </summary>
   public class Section
   {
      /// <summary>
      /// Der Name der Sektion
      /// </summary>
      public string Name;

      /// <summary>
      /// Die Einstellungen der Sektion
      /// </summary>
      public Settings Settings;

      /// <summary>
      /// Konstruktor
      /// </summary>
      /// <param name="sectionName">Der Name der Sektion</param>
      public Section(string sectionName)
      {
         this.Name = sectionName;
         this.Settings = new Settings();
      }
   }

   /// <summary>
   /// Auflistung zur Speicherung von Sektionen
   /// </summary>
   public class Sections : Dictionary<string, Section>
   {
      /// <summary>
      /// Fügt der Auflistung ein neues Section-Objekt hinzu
      /// </summary>
      /// <param name="name">Der Name der Sektion</param>
      public void Add(string name)
      {
         this.Add(name, new Section(name));
      }
   }

   /// <summary>
   /// Klasse zur Verwaltung von Konfigurationsdaten
   /// </summary>
   public class Config
   {
      /// <summary>
      /// Speichert den Dateinamen der XML-Datei
      /// </summary>
      private string fileName;

      /// <summary>
      /// Verwaltet die Sektionen
      /// </summary>
      public Sections Sections;

      /// <summary>
      /// Konstruktor
      /// </summary>
      /// <param name="fileName">Der Dateiname der XML-Datei</param>
      public Config(string fileName)
      {
         this.fileName = fileName;
         this.Sections = new Sections();
      }

      /// <summary>
      /// Ließ die Konfigurationsdaten
      /// </summary>
      /// <returns>Gibt true zurück wenn das Lesen erfolgreich war</returns>
      public bool Load()
      {
         // Variable für den Rückgabewert
         bool returnValue = true;

         // XmlDocument-Objekt für die Einstellungs-Datei erzeugen
         XmlDocument xmlDoc = new XmlDocument();

         // Datei laden
         try
         {
            xmlDoc.Load(this.fileName);
         }
         catch (IOException ex)
         {
            throw new IOException("Fehler beim Laden der Konfigurationsdatei '" +
               this.fileName + "': " + ex.Message);
         }
         catch (XmlException ex)
         {
            throw new XmlException("Fehler beim Laden der Konfigurationsdatei '" +
               this.fileName + "': " + ex.Message, ex);
         }

         // Alle Sektionen durchgehen und die Einstellungen einlesen
         foreach (Section section in this.Sections.Values)
         {
            // Alle Einstellungen der Sektion durchlaufen
            foreach (Setting setting in section.Settings.Values)
            {
               // Einstellung im XML-Dokument lokalisieren
               XmlNode settingNode = xmlDoc.SelectSingleNode(
                  "/config/" + section.Name + "/" + setting.Name);
               if (settingNode != null)
               {
                  // Einstellung gefunden
                  setting.Value = settingNode.InnerText;
                  setting.WasInFile = true;
               }
               else
               {
                  // Einstellung nicht gefunden
                  setting.Value = setting.DefaultValue;
                  setting.WasInFile = false;
                  returnValue = false;
               }
            }
         }

         // Ergebnis zurückmelden
         return returnValue;
      }

      /// <summary>
      /// Speichert die Konfigurationsdaten
      /// </summary>
      public void Save()
      {
         // XmlDocument-Objekt für die Einstellungs-Datei erzeugen
         XmlDocument xmlDoc = new XmlDocument();

         // Skelett der XML-Datei erzeugen
         xmlDoc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" " +
            "standalone=\"yes\"?><config></config>");

         // Alle Sektionen durchgehen und die Einstellungen schreiben
         foreach (Section section in this.Sections.Values)
         {
            // Element für die Sektion erzeugen und anfügen
            XmlElement sectionElement = xmlDoc.CreateElement(section.Name);
            xmlDoc.DocumentElement.AppendChild(sectionElement);

            // Alle Einstellungen der Sektion durchlaufen
            foreach (Setting setting in section.Settings.Values)
            {
               // Einstellungs-Element erzeugen und anfügen
               XmlElement settingElement =
                  xmlDoc.CreateElement(setting.Name);
               settingElement.InnerText = setting.Value;
               sectionElement.AppendChild(settingElement);
            }
         }

         // Datei speichern
         try
         {
            xmlDoc.Save(this.fileName);
         }
         catch (IOException ex)
         {
            throw new IOException("Fehler beim Speichern der " +
               "Konfigurationsdatei '" + this.fileName + "': " + ex.Message);
         }
         catch (XmlException ex)
         {
            throw new XmlException("Fehler beim Speichern der " +
               " Konfigurationsdatei '" + this.fileName + "': " +
               ex.Message, ex);
         }
      }
   }
}
