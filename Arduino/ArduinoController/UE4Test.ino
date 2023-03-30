int Xaxislog = A0;
int Yaxislog = A1;
float XaxisValue = 0;
float YaxisValue = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(3, INPUT_PULLUP);
  pinMode(9, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  //InteractButton();
  //Yaxis();
  //Xaxis();
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
  digitalWrite(9, !digitalRead(3));
  Serial.print(!digitalRead(3));
  Serial.println();
}

void Movement()
{
  digitalWrite(6, Output)
}