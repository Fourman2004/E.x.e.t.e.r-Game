int Xaxislog = A0;
int Yaxislog = A1;
float XaxisValue = 0;
float YaxisValue = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(3, INPUT_PULLUP);
  pinMode(9, OUTPUT);
  pinMode(10, INPUT_PULLUP);
  pinMode(11, OUTPUT);
  pinMode(5, INPUT_PULLUP);
  pinMode(6, OUTPUT);
  pinMode(13, INPUT_PULLUP);
  pinMode(12, OUTPUT);
  pinMode(4, INPUT_PULLUP);
  pinMode(7, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  //InteractButton();
  //Yaxis();
  //Xaxis();
  Movement();
}

void Yaxis() {
YaxisValue = map(analogRead(Yaxislog), 0, 1023,0 ,1023);
Serial.println("Y Axis:" + analogRead(Yaxislog));
}

void Xaxis() {
  XaxisValue = map(analogRead(Xaxislog), 0, 1023, 0, 1023);
  Serial.println("X Axis:" + analogRead(Xaxislog));
}

void InteractButton()
{
  digitalWrite(9,!digitalRead(3));
  Serial.print("Interaction:" + !digitalRead(3));
  Serial.println();
}

void Movement()
{
  //digitalWrite(6,!digitalRead(5));
  digitalWrite(12,!digitalRead(13));
  //digitalWrite(7, digitalRead(4));
  //digitalWrite(11,!digitalRead(10));
 //Serial.print(!digitalRead(5));
 Serial.print(!digitalRead(13));
 //Serial.print(digitalRead(4));
 //Serial.print(!digitalRead(10));
 delay(1000); 
 Serial.println();
}