#line 1 "C:/Users/duymy/Desktop/COM/vi_dieu_khien/COM.c"
#line 37 "C:/Users/duymy/Desktop/COM/vi_dieu_khien/COM.c"
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

 if ( dat ==  'A' )
 {
 RE0_bit = 0;
 UART1_Write( '1' );
 }

 if ( dat ==  'H' )
 {
 RE0_bit = 1;
 UART1_Write( '6' );
 }

 if ( dat ==  'B' )
 {
 RE1_bit = 0;
 UART1_Write( '2' ) ;
 }

 if ( dat ==  'J' )
 {
 RE1_bit = 1;
 UART1_Write( '7' );
 }

 if ( dat ==  'C' )
 {
 RE2_bit = 0;
 UART1_Write( '3' );
 }

 if ( dat ==  'K' )
 {
 RE2_bit = 1;
 UART1_Write( '8' );
 }




 if ( dat ==  'D' )
 {
 if(state1 == 2)
 delay_ms(2000);

 RD0_bit = 0;
 RD1_bit = 0;
 UART1_Write( '4' ) ;
 state1 = 1;
 }


 if ( dat ==  'E' )
 {
 if(state1 == 1)
 delay_ms(2000);
 RD0_bit = 0;
 RD1_bit = 1;
 UART1_Write( '5' ) ;
 state1=2;
 }


 if ( dat ==  'F' )
 {
 RD0_bit = 1;
 RD1_bit = 1;
 UART1_Write( 'Q' ) ;
 state1=0;


 }





 if ( dat ==  'L' )
 {
 if(state2==2)
 delay_ms(2000);

 RD2_bit = 0;
 RD3_bit = 0;
 UART1_Write( '9' ) ;
 state2 = 1;


 }


 if ( dat ==  'Z' )
 {
 if(state2 == 1)
 delay_ms(2000);

 RD2_bit = 0;
 RD3_bit = 1;
 UART1_Write( '0' ) ;
 state2 = 2;


 }


 if ( dat ==  'M' )
 {
 RD2_bit = 1;
 RD3_bit = 1;
 UART_Write( 'I' ) ;
 state2=0;

 }

 }
}
