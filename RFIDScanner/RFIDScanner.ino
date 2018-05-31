/*
 Name:		RFIDScanner.ino
 Created:	01-May-18 8:45:39 PM
 Author:	ekampourakis
*/

#include <SPI.h>
#include <MFRC522.h>
#include <EnhancedSerial.h>

#define Debug

#ifdef Debug
  EnhancedSerial ES;
#endif

#define RST_PIN 9
#define SS_PIN 10

MFRC522 mfrc522(SS_PIN, RST_PIN);

void setup() {
  #ifndef Debug
    ES.Init(13);
    ES.SetPingMessage(0, 255);
    ES.WaitConnect();
  #else
    Serial.begin(115200);
    while (!Serial) {}
  #endif
  SPI.begin();
  mfrc522.PCD_Init();
}

byte RFIDData[4] = {0};

void loop() {
	if (CheckCard()) {
	  // We have new RFID data to transmit
    Serial.write(0x01);
    Serial.write(RFIDData, 4);
    Serial.write(0x02);
	}
}

void SerialEvent() {
	// Process serial data
}

bool CheckCard() {
  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    //mfrc522.PICC_DumpToSerial(&(mfrc522.uid));    
    for (byte i = 0; i < 4; i++) { RFIDData[i] = mfrc522.uid.uidByte[i]; }
    mfrc522.PICC_HaltA();
    return true;
  }
  return false;
}
