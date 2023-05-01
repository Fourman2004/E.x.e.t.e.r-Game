

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  //inputs lead to buttons, using digital pins
  pinMode(3, INPUT);
  pinMode(6, INPUT);
  pinMode(5, INPUT);
  pinMode(9, INPUT);
  //outputs lead to digital pins
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(4, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  //all methods do the same thing, only one shall be commented for this reason
 Up();
 delay(100);
 left(); 
 delay(100);
 right();
 delay(100);
 down();
 delay(100);
}

void Up()
{
  //Reads the output pin and the input pin
  digitalWrite(11, digitalRead(3));
  //prints the Input pin to serial
  Serial.print(digitalRead(3));
  //prints serial to the monitor
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