#include <16F887.h>
#include <stdlib.h>


// Cau hinh su dung dao dong noi 4MHz
#fuses HS,NOWDT,NOPROTECT,NOLVP
#use delay(clock=4000000)
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7, stream=MYPC)

const char ma7doan[11] = {0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90}; 
long num=0,ngan,tram,chuc,donvi;


void display(long num)
{ 

   
   ngan=num/1000;
   tram=(num/100)%10;
   chuc=(num/10)%10;
   donvi=num%10;
   
   output_d(ma7doan[ngan]);
   output_b(0x7F);
   delay_ms(1);
   output_b(0xFF);

   output_d(ma7doan[tram]);
   output_b(0xBF);
   delay_ms(1);
   output_b(0xFF);

   output_d(ma7doan[chuc]);
   output_b(0xDF);
   delay_ms(1);
   output_b(0xFF);

   output_d(ma7doan[donvi]);
   output_b(0xEF);
   delay_ms(1);
   output_b(0xFF);
}


void main()
{
 
   set_tris_b(0);
   set_tris_d(0x80);
      
   
      while(true)
      {
         if(!input(pin_c0))
            {       
               num++;
               while(!input(pin_c0))
               {
                  display(num);
                  printf("@%04ld",num);    
               }
                 
            }
         display(num);    
      }
   
}

