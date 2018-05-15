/*
 Name:		RFIDScanner.ino
 Created:	01-May-18 8:45:39 PM
 Author:	Manos
*/

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(115200);
	while (!Serial) {}

}

// the loop function runs over and over again until power down or reset
void loop() {
	
}

// Array to store RFID data
byte data[64] = {0};
// The timeout interval of the data array that indicates the time the RFID data was scanned
unsigned long RFIDRead = 0;
// This flag indicated if we have RFID data waiting for transmission
bool RFIDAvailable = false;

// This functions gets activated when a new card is scanned
void OnScan() {
	// Store RFID data to data[] array
	
	// This array has a timeout interval
	RFIDRead = millis();

	// Send to serial port the card read signal
	Serial.write(255); // or something
}

// This function gets called when we receive serial data
void SerialEvent() {
	// Process serial data
}