

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  //inputs lead to buttons, using digital pins
  pinMode(3, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(9, INPUT_PULLUP);
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
  //Detects if the input pin is 0
  if(digitalRead(3) == 0)
  { //prints a value to serial
  Serial.print(3);
  //prints serial to the monitor
  }
  Serial.println();
}

void left()
{
 if(digitalRead(5) == 0)
 {
 Serial.print(5);
 }
 Serial.println();
}

void right()
{
   if(digitalRead(6) != 0)
 {
 Serial.print(6);
 }
 Serial.println();
}

void down()
{
  if(digitalRead(9) == 0)
 {
 Serial.print(9);
 }
 Serial.println();
}