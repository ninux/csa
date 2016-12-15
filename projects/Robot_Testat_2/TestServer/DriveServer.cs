using RobotCtrl;
using RobotView;
using System;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace TestServer
{
    class DriveServer
    {
        #region members
        private Robot robot1;

        private float speed;
        private float acceleration;
        #endregion

        #region constructor & destructor
        public DriveServer()
        {
            robot1 = new Robot();        // neuen Roboter erstellen
            robot1.Drive.Power = true;   // Stromversorgung der Motoren (im DriveCtrl) einschalten

            speed = 0.5F;
            acceleration = 0.3F;

            // Server starten
            IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            //TcpListener listen = new TcpListener(IPAddress.Any, 80);
            TcpListener listen = new TcpListener(ipAddress, 80);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " + listen.LocalEndpoint + "...");
                TcpClient client = listen.AcceptTcpClient();
                Console.WriteLine("Handler für " + client.Client.RemoteEndPoint + " erzeugen und starten");
                ReadHttpFile(client);
                StartDrive();
            }
        }
        #endregion


        public void ReadHttpFile(TcpClient client)
        {
            string line;
            StreamReader sr = new StreamReader(client.GetStream());
            //StreamWriter sw = new StreamWriter(client.GetStream());
            StreamWriter sw_file = new StreamWriter(@"\Drive.txt");
            Console.WriteLine("Verbindung zu " + client.Client.RemoteEndPoint);
            // Datei zeilenweise lesen und lokal schreiben
            while ((line = sr.ReadLine()) != "Start")
            {
                sw_file.WriteLine(line);
            }


            // Datei im HTTP-Format senden
            // todo!

            client.Close();
        }


        public void StartDrive()
        {
            string line;
            StreamReader sr = new StreamReader(@"\Drive.txt");
            // Datei zeilenweise lesen und abarbeiten
            while ((line = sr.ReadLine()) != null)
            {
                // extract text and values
                string command = line.Split(' ')[0];
                string value1 = line.Split(' ')[1];
                string value2 = line.Split(' ')[2];

                float length;
                int angle;
                float radius;

                switch (command)
                {
                    case "TrackLine":
                        length = (float)Convert.ToDouble(value1);
                        robot1.Drive.RunLine(length, speed, acceleration);
                        break;
                    case "TrackTurnLeft":
                        angle = (int)Convert.ToInt16(value1);
                        robot1.Drive.RunTurn(-angle, speed, acceleration);
                        break;
                    case "TrackTurnRight":
                        angle = (int)Convert.ToInt16(value1);
                        robot1.Drive.RunTurn(angle, speed, acceleration);
                        break;
                    case "TrackArcLeft":
                        angle = (int)Convert.ToInt16(value1);
                        radius = (float)Convert.ToDouble(value2);
                        robot1.Drive.RunArcLeft(radius, angle, speed, acceleration);
                        break;
                    case "TrackArcRight":
                        angle = (int)Convert.ToInt16(value1);
                        radius = (float)Convert.ToDouble(value2);
                        robot1.Drive.RunArcRight(radius, angle, speed, acceleration);
                        break;
                }
            }
        }
    }
}