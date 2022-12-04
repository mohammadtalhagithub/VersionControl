boolean softParaSendFlag = false;
boolean softFileSendFlag = false;

void setup() {
  //Serial.begin(115200);
  Serial.begin(9600);
/*  300
1200
                    2400
                    4800
                    9600
                    19200
                    38400
                    57600
                    74880
                    115200
                    230400
                    250000
                    500000
                    1000000*/
}
//void(* resetFunc) (void) = 0;  // declare reset fuction at address 0

void loop() {


  if (Serial.available())
  {
    String rawString = Serial.readStringUntil('\n');
    //resetFunc(); //call reset2
    rawString.trim();
    //Serial.println(rawString);
    delay(500);
    //* resetFunc();
    if (rawString.indexOf("$:start") > -1) {
      //resetFunc();
      //delay(100);
      //Serial.println(rawString);
      Serial.println("@:connect");
      //      Serial2.println("@501:connect");
      delay(100);

      float batVolt = 6;

      String _batVolt = String(batVolt);

      String batPerc = String((batVolt / 12) * 100, 2);

      Serial.println("@500:devtype:IAQ");
      Serial.println("@500:pid:WDRA-2.2.2");
      Serial.println("@500:ser:WDRA300522_26");
      Serial.println("@500:dtime:30/05/2022 20:36");
      Serial.println("@500:savet:1");
      Serial.println("@500:sendt:1");
      Serial.println("@500:batvolt:" + _batVolt);
      Serial.println("@500:batperc:" + batPerc);

    }
    else if (rawString.indexOf("$:stop") > -1)
    {
      Serial.println("@:disconnect");
    }

    int caseNo = rawString.substring(rawString.indexOf('$') + 1, rawString.indexOf(':')).toInt();

    switch (caseNo)
    {
      case 500: { // For Connect
          delay(100);
          softParaSendFlag = false;
          softFileSendFlag = false;


          break;
        }
      case 501: { // For Setup
          delay(100);
          softParaSendFlag = false;
          softFileSendFlag = false;

          break;
        }

      case 502: {// For Backup
          softParaSendFlag = false;
          softFileSendFlag = true;

          String trigger = rawString.substring(rawString.indexOf(':') + 1, rawString.indexOf('_'));

          if (trigger == "startbackup")
          {
            String FileName[9] = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight"};
            String FileExt[9] = {"", ".csv", ".csv", ".csv", ".csv", ".csv", ".csv", ".csv", ".csv"};

            delay(500);

            if (Serial.available() == false)
            {
              for (int i = 1; i < 9; i++) {
                Serial.println("@502:" + String(i) + ":" + FileName[i] + FileExt[i]);
                delay(8);
              }
            }
          }

          else if (trigger == "savefileNo")//$502:savefileNo_1_
          {
            //char celsius = '\u00B0';

            Serial.println("/*11-Aug-2022*/"); // Name of the file to be saved on computer
            delay(50);
            Serial.println("SavedData");
            Serial.println("Temperature, Humidity, Velocity, PM10");//54.0 µg/m³
            Serial.println("*C, %, m/s, ug/m3");

            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("65, 72, 5, 54");
            Serial.println("62, 70, 6, 55");
            Serial.println("66, 75, 5, 52");
            
            Serial.println("done");
            delay(100);
            Serial.println("AllDone");

          }

          break;
        }
      case 503: {// FOR Dashboard
          //delay(100);
          softParaSendFlag = true;
          softFileSendFlag = false;

          String paraName[5] = {"Temperature", "Relative Humidity", "Soil Moisture", "Wind Direction", "Temperature"};
          String paraValue[5] = {"52", "41", "48", "76", "60,000"};
          String paraUnit[5] = {"℃", "%", "ug/m3", "North", "℃"};



          if (softParaSendFlag)
          {
            //delay(500);

            int i = 0;

            //Serial.println("@503:Show_Tiles");

            while (Serial.available() == false)
            {
              Serial.println("@503:1:Temperature:" + String(i) + ":" + "Unit"); // + "1" + ":" + "Temperature" + ":" + ":" + "Unit");
              Serial.println("@503:2:Wind Speed:" + String(i + 5) + ":" + "m/s");
              Serial.println("@503:3:Wind Direction:" + String(i + 1) + ":" + "NE");
              Serial.println("@503:4:Soil Moisture:" + String(i + 2) + ":" + "%/wt");
              Serial.println("@503:5:Water Level:" + String(i + 3) + ":" + "m");
              Serial.println("@503:6:Solar Radiation:" + String(i + 6) + ":" + "W/m2");
              Serial.println("@503:7:Humidity:" + String(i + 8) + ":" + "%");
              Serial.println("@503:8:Rainfall:" + String(i + 7) + ":" + "mm");

              
              
              //Serial.println("@503:ShowTiles");// send this keyword only once

              delay(1000);
              i++;
            }

            /*for (int i = 0; i < 100; i++) {
              // Serial.println("@503:" + String(i + 1) + ":" + paraName[i] + ":" + paraValue[i] + ":" + paraUnit[i]);

              Serial.println("@503:1:Temperature:" + String(i) + ":" + "Unit"); // + "1" + ":" + "Temperature" + ":" + ":" + "Unit");
              Serial.println("@503:2:Humidity:" + String(i + 1) + ":" + "%");
              Serial.println("@503:3:Velocity:" + String(i + 2) + ":" + "m/s");
              Serial.println("@503:4:Water Level:" + String(i + 3) + ":" + "m");
              Serial.println("@503:5:CO2:" + String(i + 4) + ":" + "mg/m3");

              //Serial.println("@503:ShowTiles");// send this keyword only once
              delay(1000);
              }*/
          }
          //Serial.println("@503:showTiles");

          break;
        }

    }//Switch case ends here

  }

}
