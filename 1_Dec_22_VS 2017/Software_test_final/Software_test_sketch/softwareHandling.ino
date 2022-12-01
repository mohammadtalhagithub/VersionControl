
void softHandle()
{

  if (Serial.available())
  {
    String recievedData = Serial.readStringUntil("\n");   //#500:@:#,  #501:data@1:#//#500:@#
    //    recievedData.trim();
    //
    //    if (recievedData == "even")
    //    {
    //      for (int i = 0; i < 100; i++)
    //      {
    //        Serial.println(i * 2);
    //        //delay(250);
    //      }
    //    }
    //
    //    else if (recievedData == "check")
    //    {
    //
    //      Serial.println("#200:Communication Successfull...!@#");
    //
    //    }
    //
    //    else if (recievedData == "open")
    //    {
    //
    //      Serial.println("#201:Opening...!@#");
    //
    //    }

    int caseNo = recievedData.substring(recievedData.indexOf('#') + 1, recievedData.indexOf(':')).toInt();    //500, 501

    recievedData.remove(0, recievedData.indexOf(':') + 1);    //@;#, data@1:#

    /* int
      Serial.println(caseNo);*/

    switch (caseNo)
    {
      //Device Info
      case 500: {     //@:#
          Serial.println("#500:DWR001@000001$12V#");
          //          Serial.println("#500:Serial No: @#");
          //          Serial.println("#500:Make     : @#");
          break;
        }
      case 501: {     //@:#
          Serial.println("#501:Case is 501@#");
          break;
        }
      case 007: {
          Serial.println("#007:RelativeHumidity@76$%#");
          break;
        }
        
      case 006: {
          Serial.println("#006:Temperature@45$℃#");
          break;
        }

      case 503: {     //@:#
          Serial.println("#503:01!Temperature$46&C@#");
          break;
        }
        //      case 202: {     //@:#
        //          Serial.print("#202:The case is 202@#");
        //
        //
        //          break;
        //        }

        //Data to software
        //      case 501: {     //data@1:#
        //
        //          if (recievedData.indexOf("data") > -1) {
        //            int maxVal = recievedData.substring(recievedData.indexOf('@') + 1, recievedData.lastIndexOf(':')).toInt();    //1, 2, 3 anything sent from software after @
        //            //            String _maxVal=maxVal.toString();
        //            Serial.println(maxVal);
        //          }
        //
        //
        //          break;
        //        }

        //      case 502: {
        //          Serial.println(caseNo);
        //          //          Serial.println("Serial No: 000001");
        //          //          Serial.println("Make     : QES");
        //          break;
        //        }

    }// switch ends here

  }//software handle

}
