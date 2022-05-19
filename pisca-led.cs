int LedA=0;
int LedV=1;

void setup () {
  pinMode (LedA, OUTPUT);
  pinMode (LedV, OUTPUT);
}

void loop () {
  digitalWrite (LedA, HIGH);
  digitalWrite (LedV, LOW);
  delay(1000);
  digitalWrite (LedA, LOW);
  digitalWrite (LedV, HIGH);
  delay(1000);
}