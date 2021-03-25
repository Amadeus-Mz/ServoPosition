#include<Servo.h>
#include<EEPROM.h>
#include<avr/wdt.h>
#define Sw 2
Servo M1;

//------------------------------------------Main Value

String Memory = "";
int Dir = 0;
int Use = 0;

bool btnGripper = 1;

unsigned long int Position = 0,
                  PositionIn1 = 0,
                  PositionOut1 = 0,
                  PositionIn2 = 0,
                  PositionOut2 = 0,
                  PositionIn3 = 0,
                  PositionOut3 = 0,
                  PositionIn4 = 0,
                  PositionOut4 = 0,
                  PositionIn5 = 0,
                  PositionOut5 = 0;
int Check = 0;
String reset = "0";
String SetZero = "0";

bool Sw1 = 0,
     Sw2 = 0,
     Sw3 = 0,
     Sw4 = 0,
     Sw5 = 0,
     TrigerMemory1 = 0,
     TrigerMemory2 = 0,
     TrigerMemory3 = 0,
     TrigerMemory4 = 0,
     TrigerMemory5 = 0;

//------------------------------------------Tx Value

String TxOut;
String TxIn1,
       TxIn2,
       TxIn3,
       TxIn4,
       TxIn5,
       TxOut1,
       TxOut2,
       TxOut3,
       TxOut4,
       TxOut5;

//------------------------------------------Rx Value

char dataIn;
String waitProcess, dataAll;
int CutDataAll;

String strMemory,
       strUse,
       strDirection,
       strPosition,
       strReset,
       strSetZero;
String OutRange1,
       OutRange2,
       OutRange3,
       OutRange4,
       OutRange5;

//------------------------------------------

void setup()
{
  Serial.begin(115200);
  pinMode(Sw, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(7, INPUT_PULLUP);

  EEPROM.get(1000, Check);

  if (Check != 1)
  {
    Use = 0;
    PositionIn1 = 0;
    PositionIn2 = 0;
    PositionIn3 = 0;
    PositionIn4 = 0;
    PositionIn5 = 0;
    PositionOut1 = 0;
    PositionOut2 = 0;
    PositionOut3 = 0;
    PositionOut4 = 0;
    PositionOut5 = 0;

    EEPROM.put(0, Use);
    EEPROM.put(10, PositionIn1);
    EEPROM.put(20, PositionIn2);
    EEPROM.put(30, PositionIn3);
    EEPROM.put(40, PositionIn4);
    EEPROM.put(50, PositionIn5);
    EEPROM.put(60, PositionOut1);
    EEPROM.put(70, PositionOut2);
    EEPROM.put(80, PositionOut3);
    EEPROM.put(90, PositionOut4);
    EEPROM.put(100, PositionOut5);

    Check = 1;
    EEPROM.put(1000, Check);
  }

  EEPROM.get(0, Use);
  EEPROM.get(10, PositionIn1);
  EEPROM.get(20, PositionIn2);
  EEPROM.get(30, PositionIn3);
  EEPROM.get(40, PositionIn4);
  EEPROM.get(50, PositionIn5);
  EEPROM.get(60, PositionOut1);
  EEPROM.get(70, PositionOut2);
  EEPROM.get(80, PositionOut3);
  EEPROM.get(90, PositionOut4);
  EEPROM.get(100, PositionOut5);

  M1.attach(9);
}

void loop()
{
  btnGripper = digitalRead(Sw);
  Sw1 = digitalRead(3);
  Sw2 = digitalRead(4);
  Sw3 = digitalRead(5);
  Sw4 = digitalRead(6);
  Sw5 = digitalRead(7);
  
  SelectorSwitch();

  RxDataAll();
  TxData();
  software_Reboot();

  MainFanction();
}

void MainFanction()
{
  if (btnGripper == 0)
  {
    if (Use == 1)
    {
      M1.write(PositionIn1);
    }
    if (Use == 2)
    {
      M1.write(PositionIn2);
    }
    if (Use == 3)
    {
      M1.write(PositionIn3);
    }
    if (Use == 4)
    {
      M1.write(PositionIn4);
    }
    if (Use == 5)
    {
      M1.write(PositionIn5);
    }
  }
  else
  {
    if (Use == 1)
    {
      M1.write(PositionOut1);
    }
    if (Use == 2)
    {
      M1.write(PositionOut2);
    }
    if (Use == 3)
    {
      M1.write(PositionOut3);
    }
    if (Use == 4)
    {
      M1.write(PositionOut4);
    }
    if (Use == 5)
    {
      M1.write(PositionOut5);
    }
  }
}

void TxData()
{
  if (CutDataAll > 0)
  {
    if (strMemory != "-")
    {
      Memory = strMemory;
    }
    if (strUse != "-")
    {
      Use = strUse.toInt();
    }
    if (strDirection != "-")
    {
      Dir = strDirection.toInt();
    }
    if (strPosition != "-")
    {
      Position = strPosition.toInt();
    }

    reset = strReset;
    SetZero = strSetZero;

    SetZeroMemory();
    SetValue();

    EEPROM.put(0, Use);
    EEPROM.put(10, PositionIn1);
    EEPROM.put(20, PositionIn2);
    EEPROM.put(30, PositionIn3);
    EEPROM.put(40, PositionIn4);
    EEPROM.put(50, PositionIn5);
    EEPROM.put(60, PositionOut1);
    EEPROM.put(70, PositionOut2);
    EEPROM.put(80, PositionOut3);
    EEPROM.put(90, PositionOut4);
    EEPROM.put(100, PositionOut5);

    TxIn1 = PositionIn1;
    TxIn2 = PositionIn2;
    TxIn3 = PositionIn3;
    TxIn4 = PositionIn4;
    TxIn5 = PositionIn5;
    TxOut1 = PositionOut1;
    TxOut2 = PositionOut2;
    TxOut3 = PositionOut3;
    TxOut4 = PositionOut4;
    TxOut5 = PositionOut5;

    TxOut = TxIn1 + "/" + TxIn2 + "/" + TxIn3 + "/" + TxIn4 + "/" + TxIn5 + "/" + TxOut1 + "/" + TxOut2 + "/" + TxOut3 + "/" + TxOut4 + "/" + TxOut5 + "/" + Use + ";";
    Serial.print(TxOut);

    waitProcess = "";
    dataAll = "";
    CutDataAll = 0;
    TxOut = "";
  }
}

void SetValue()
{
  if (Memory == "1")
  {
    if (Dir == 1)
    {
      PositionIn1 = Position;
    }
    else if (Dir == 2)
    {
      PositionOut1 = Position;
    }
  }
  else if (Memory == "2")
  {
    if (Dir == 1)
    {
      PositionIn2 = Position;
    }
    else if (Dir == 2)
    {
      PositionOut2 = Position;
    }
  }
  else if (Memory == "3")
  {
    if (Dir == 1)
    {
      PositionIn3 = Position;
    }
    else if (Dir == 2)
    {
      PositionOut3 = Position;
    }
  }
  else if (Memory == "4")
  {
    if (Dir == 1)
    {
      PositionIn4 = Position;
    }
    else if (Dir == 2)
    {
      PositionOut4 = Position;
    }
  }
  else if (Memory == "5")
  {
    if (Dir == 1)
    {
      PositionIn5 = Position;
    }
    else if (Dir == 2)
    {
      PositionOut5 = Position;
    }
  }
}

String RxDataAll()
{
  if (Serial.available() > 0)
  {
    dataIn = Serial.read();
    waitProcess += dataIn;
    CutDataAll = waitProcess.indexOf(";");
  }

  dataAll = waitProcess.substring(0, CutDataAll);
  RxMemoryData(dataAll);

  return dataAll;
}

String RxMemoryData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf("/");
  strMemory = dataCut.substring(0, Cut);

  OutRange1 = dataCut.substring(Cut + 1);
  RxUseData(OutRange1);

  return strMemory;
}

String RxUseData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf("/");
  strUse = dataCut.substring(0, Cut);

  OutRange2 = dataCut.substring(Cut + 1);
  RxDirectionData(OutRange2);

  return strUse;
}

String RxDirectionData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf("/");
  strDirection = dataCut.substring(0, Cut);

  OutRange3 = dataCut.substring(Cut + 1);
  RxPositionData(OutRange3);

  return strDirection;
}

String RxPositionData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf("/");
  strPosition = dataCut.substring(0, Cut);

  OutRange4 = dataCut.substring(Cut + 1);
  RxResetData(OutRange4);

  return strPosition;
}

String RxResetData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf("/");
  strReset = dataCut.substring(0, Cut);

  OutRange5 = dataCut.substring(Cut + 1);
  RxSetZeroData(OutRange5);

  return strReset;
}

String RxSetZeroData(String dataCut)
{
  int Cut;
  Cut = dataCut.indexOf(";");
  strSetZero = dataCut.substring(0, Cut);

  return strSetZero;
}

void software_Reboot()
{
  if (reset == "1")
  {
    wdt_enable(WDTO_15MS);
    while (1)
    {
    }
  }
  else
  {
  }
}

void SetZeroMemory()
{
  if (SetZero == "1")
  {
    PositionIn1 = 0;
    PositionIn2 = 0;
    PositionIn3 = 0;
    PositionIn4 = 0;
    PositionIn5 = 0;
    PositionOut1 = 0;
    PositionOut2 = 0;
    PositionOut3 = 0;
    PositionOut4 = 0;
    PositionOut5 = 0;
  }
  else
  {
  }
}

void SelectorSwitch()
{
  if (Sw1 == 0)
  {
    if (TrigerMemory1 == 0)
    {
      Use = 1;
      TxOut = "-/-/-/-/-/-/-/-/-/-/1;";
      Serial.print(TxOut);
      EEPROM.put(0, Use);
      TrigerMemory1 = 1;
    }
  }
  else
  {
    TrigerMemory1 = 0;
  }
  if (Sw2 == 0)
  {
    if (TrigerMemory2 == 0)
    {
      Use = 2;
      TxOut = "-/-/-/-/-/-/-/-/-/-/2;";
      Serial.print(TxOut);
      EEPROM.put(0, Use);
      TrigerMemory2 = 1;
    }
  }
  else
  {
    TrigerMemory2 = 0;
  }
  if (Sw3 == 0)
  {
    if (TrigerMemory3 == 0)
    {
      Use = 3;
      TxOut = "-/-/-/-/-/-/-/-/-/-/3;";
      Serial.print(TxOut);
      EEPROM.put(0, Use);
      TrigerMemory3 = 1;
    }
  }
  else
  {
    TrigerMemory3 = 0;
  }
  if (Sw4 == 0)
  {
    if (TrigerMemory4 == 0)
    {
      Use = 4;
      TxOut = "-/-/-/-/-/-/-/-/-/-/4;";
      Serial.print(TxOut);
      EEPROM.put(0, Use);
      TrigerMemory4 = 1;
    }
  }
  else
  {
    TrigerMemory4 = 0;
  }
  if (Sw5 == 0)
  {
    if (TrigerMemory5 == 0)
    {
      Use = 5;
      TxOut = "-/-/-/-/-/-/-/-/-/-/5;";
      Serial.print(TxOut);
      EEPROM.put(0, Use);
      TrigerMemory5 = 1;
    }
  }
  else
  {
    TrigerMemory5 = 0;
  }
}
