int Xaxislog = A0;
int Yaxislog = A1;
float XaxisValue = 0;
float YaxisValue = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(3, INPUT_PULLUP);
  pinMode(9, OUTPUT);
  pinMode(6, INPUT_PULLUP);
  pinMode(11, OUTPUT);
  pinMode(5, INPUT_PULLUP);
  pinMode(10, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(4, INPUT_PULLUP);
}

void loop() {
  // put your main code here, to run repeatedly:
  
 //Up();
 left();
}

void Up()
{
  digitalWrite(9,!digitalRead(3));
  Serial.print(!digitalRead(3));
  Serial.println();
}

void left()
{
digitalWrite(10 ,!digitalRead(5));
Serial.print(!digitalRead(5));
Serial.println();
}
