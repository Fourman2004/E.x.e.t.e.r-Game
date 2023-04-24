

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(3, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(9, INPUT_PULLUP);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(4, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  
 //Up();
 left();
}

void Up()
{
  digitalWrite(11, digitalRead(3));
  Serial.print(digitalRead(3));
  Serial.println();
}

void left()
{
digitalWrite(10,digitalRead(5));
Serial.print(digitalRead(5));
Serial.println();
}

void right()
{
  digitalWrite(4, !digitalRead(6));
  Serial.print(!digitalRead(6));
  Serial.println();
}

void down()
{
  digitalWrite(13, digitalRead(9));
  Serial.print(digitalRead(9));
  Serial.println();
}