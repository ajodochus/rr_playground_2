:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: neue UserControl erstellen, bzw. neue Oberfläche
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



1) in den Visual studio Optionen unter "Windows Forms-Designer / Allgemein / Toolbox" den Wert für "Toolbox automatisch auffüllen" auf true setzen, damit die UserControls nach einem Rebuild auch in der Toolbox erscheinen
2) ein neues .net Klassenbibliothek DLL(!!!) Projekt anlegen
3) in diesem Projekt ein neues Benutzersteuerungselement hinzufügen (Projekt / Benutzersteuerelement hinzufügen)
4) im usercode des Benutzersteuerelement ein Feld für die Instanz anlegen, z.B:
die _instance muss so heißen wie die Klasse

 private static rgb_slider _instance;

        public static rgb_slider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new rgb_slider();
                }
                return _instance;
            }
        }

5) in der WinForm den Aufruf der Instanz hinzufügen z.B
(eventuell das Usercontrol aus der Toolbox auf die WinForm ziehen und wieder löschen. Danach ist sie mit autocomplete-code erreichbar)
6) Im Menü einen neuen Button anlegen, benennen und doppelklicken
eine neue clickon methode wird angelegt
darin folgenden code kopieren und anpassen

(((((((((( private void btn_system_datetime_Click(object sender, EventArgs e) ))))))))))))))))))))))
        {
            if (!panel.Controls.Contains(Usercontrol_datetime.Usercontrol_datetime.Instance))
            {
                panel.Controls.Add(Usercontrol_datetime.Usercontrol_datetime.Instance);
                Usercontrol_datetime.Usercontrol_datetime.Instance.Dock = DockStyle.Fill;
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
            else
            {
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
        }


