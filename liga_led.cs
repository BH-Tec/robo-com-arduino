int LED=13; // LED da porta 13

void setup() {
	pinMode(LED, OUTPUT); // defini o pino 13 como saída
}

void loop() {
	digitalWrite(LED, HIGH); // liga o led
	delay(1000);
	digitalWrite(LED, LOW); // desliga o led
	delay(1000);
}