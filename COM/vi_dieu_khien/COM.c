#define     mcu_led_on1         '1'
#define     mcu_led_on2         '2'
#define     mcu_led_on3         '3'
#define     mcu_led_on4         '4'
#define     mcu_led_on5         '5'
#define     mcu_led_on6         'Q'
#define     mcu_led_on7         'W'

#define     mcd_led_of1         '6'
#define     mcd_led_of2         '7'
#define     mcd_led_of3         '8'
#define     mcd_led_of4         '9'
#define     mcd_led_of5         '0'
#define     mcd_led_of6         'I'
#define     mcd_led_of7         'P'

#define      pc_led_on1         'A'
#define      pc_led_on2         'B'
#define      pc_led_on3         'C'
#define      pc_led_on4         'D'
#define      pc_led_on5         'E'
#define      pc_led_on6         'F'
#define      pc_led_on7         'G'


#define      pc_led_of1         'H'
#define      pc_led_of2         'J'
#define      pc_led_of3         'K'
#define      pc_led_of4         'L'
#define      pc_led_of5         'Z'
#define      pc_led_of6         'M'
#define      pc_led_of7         'N'




unsigned char dat;
unsigned int state1=0,state2=0;

void main(){
  ADCON1 = 0x0F;
  CMCON = 0x07;
  PORTB = 0x00;
  LATB = 0x0F;
  TRISB0_bit = 0;
  TRISB1_bit = 0;
  TRISB2_bit = 0;
  TRISB3_bit = 0;

  PORTD = 0x00;
  LATD = 0x00;
  TRISD1_bit = 0;
  TRISD0_bit = 0;
  TRISD2_bit = 0;
  TRISD3_bit = 0;

  RD0_bit = 1;
  RD1_bit = 1;
  RD2_bit = 1;
  RD3_bit = 1;



  PORTE = 0x00;
  LATE = 0x07;
  TRISE0_bit = 0;
  TRISE1_bit = 0;
  TRISE2_bit = 0;

  UART1_Init(9600);
  delay_ms(100);
  while(1)
  {
    dat = UART1_Read();
     //LED 1
    if ( dat ==  pc_led_on1)
    {
       RE0_bit = 0;
       UART1_Write(mcu_led_on1);
    }

    if ( dat == pc_led_of1)
    {
       RE0_bit = 1;
       UART1_Write(mcd_led_of1);
    }
    //led 2
    if ( dat ==  pc_led_on2)
    {
       RE1_bit = 0;
       UART1_Write(mcu_led_on2)    ;
    }

    if ( dat == pc_led_of2)
    {
       RE1_bit = 1;
       UART1_Write(mcd_led_of2);
    }
    //led 3
    if ( dat ==  pc_led_on3)
    {
       RE2_bit = 0;
       UART1_Write(mcu_led_on3);
    }

    if ( dat == pc_led_of3)
    {
       RE2_bit = 1;
       UART1_Write(mcd_led_of3);
    }



    //motor 1 thuan
    if ( dat ==  pc_led_on4)
    {
       if(state1 == 2)
                delay_ms(2000);
                
       RD0_bit = 0;
       RD1_bit = 0;
       UART1_Write(mcu_led_on4) ;
       state1 = 1;
    }

    //motor 1 nghich
    if ( dat ==  pc_led_on5)
    {
       if(state1 == 1)
                delay_ms(2000);
       RD0_bit = 0;
       RD1_bit = 1;
       UART1_Write(mcu_led_on5) ;
       state1=2;
    }

    //mortor 1 dung
       if ( dat ==  pc_led_on6)
    {
       RD0_bit = 1;
       RD1_bit = 1;
       UART1_Write(mcu_led_on6) ;
       state1=0;


    }

  ///-------------------------------------


      //motor 2 thuan
    if ( dat ==  pc_led_of4)
    {
       if(state2==2)
                    delay_ms(2000);
                    
       RD2_bit = 0;
       RD3_bit = 0;
       UART1_Write(mcd_led_of4) ;
       state2 = 1;


    }

    //motor 2 nghich
    if ( dat ==  pc_led_of5)
    {
       if(state2 == 1)
                 delay_ms(2000);
                 
       RD2_bit = 0;
       RD3_bit = 1;
       UART1_Write(mcd_led_of5) ;
       state2 = 2;


    }

    //motor 2 dung
       if ( dat ==  pc_led_of6)
    {
       RD2_bit = 1;
       RD3_bit = 1;
       UART_Write(mcd_led_of6) ;
       state2=0;

    }

 }
}