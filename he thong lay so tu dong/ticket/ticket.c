#include <16F887.h>
#include<stdlib.h>
// Cau hinh su dung dao dong noi 4MHz
#fuses HS,NOWDT,NOPROTECT,NOLVP
#use delay(clock=4000000)
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7, stream=MYPC)

// Khai bao bien.
unsigned char ngan,tram,chuc,donvi;   
const char a[10] = {0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90}; 
long count=0;
char temp;

#int_rda
void isr()
{
   temp = fgetc(MYPC);
   if(temp == '&' || temp == '@' )
         count++;
}


void display(long num)
{   
   ngan=num/1000;
   tram=(num/100)%10;
   chuc=(num/10)%10;
   donvi=num%10;

   output_d(a[ngan]);
   output_b(0x7F);
   delay_ms(1);
   output_b(0xFF);

   output_d(a[tram]);
   output_b(0xBF);
   delay_ms(1);
   output_b(0xFF);

   output_d(a[chuc]);
   output_b(0xDF);
   delay_ms(1);
   output_b(0xFF);

   output_d(a[donvi]);
   output_b(0xEF);
   delay_ms(1);
   output_b(0xFF);
}
void main()
{
   
      
   
   while(true)
   {
   
      enable_interrupts(global);
      enable_interrupts(int_rda);
      set_tris_b(0);
      set_tris_d(0x80);  
      
      
      if(!input(pin_c0))
      {      
      
     
         while(!input(pin_c0))
         {
            display(count);
            
         }
         
         
        count++;
         printf("!%04ld.",count);

      }
      
      display(count);
   }
 }




