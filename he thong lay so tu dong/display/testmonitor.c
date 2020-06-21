#include <16F877A.h>
#include <stdlib.h>
#include <string.h>


// Cau hinh su dung dao dong noi 4MHz
#fuses HS,NOWDT,NOPROTECT,NOLVP
#use delay(clock=4000000)
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7, stream=MYPC)
// Khai bao bien.
const char ma7doan[11] = {0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90,0xFF}; 


int8 count=0;

int8 a1[4];
int8 a2[4];

char getted_data[5];


char getted_char;

void display1()
{ 
//-------------line1   
   output_d(ma7doan[1]);
   output_b(0x7F);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a1[0]]);
   output_b(0xBF);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a1[1]]);
   output_b(0xDF);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a1[2]]);
   output_b(0xEF);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a1[3]]);
   output_b(0xF7);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

}

void display2()
{

   output_d(ma7doan[2]);
   output_b(0xFB);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);


   output_d(ma7doan[a2[0]]);
   output_b(0xFD);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);


   output_d(ma7doan[a2[1]]);
   output_b(0xFE);
   output_e(0b111);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a2[2]]);
   output_b(0xFF);
   output_e(0b011);
   delay_ms(1);
   output_d(ma7doan[10]);

   output_d(ma7doan[a2[3]]);
   output_b(0xFF);
   output_e(0b101);
   delay_ms(1);
   output_d(ma7doan[10]);
}


#int_rda
void receive_isr()
{


getted_char = fgetc(MYPC);

getted_data[count] == getted_char;


if(strlen(getted_data) == 5)
{
   if(getted_data[0] == '&')
   {
      for(int i = 1 ;i<=4 ; i++)
         a1[i-1] = getted_data[i] - 48;
   }
   
   else if(getted_data[0] == '@')
   {
      for(int i = 1 ; i<=4 ; i++)
         a2[i-1] = getted_data[i] - 48;
   }
        
   count++;
}
 
}

void main()
{

      set_tris_b(0);
      set_tris_d(0);
      set_tris_e(0); 
      enable_interrupts(int_rda);
      enable_interrupts(GLOBAL);
      
 
    
      
      while(true)
      {
         display1();
         display2();
      }
   
}

