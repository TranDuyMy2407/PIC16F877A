
_main:

;COM.c,40 :: 		void main(){
;COM.c,41 :: 		ADCON1 = 0x0F;
	MOVLW       15
	MOVWF       ADCON1+0 
;COM.c,42 :: 		CMCON = 0x07;
	MOVLW       7
	MOVWF       CMCON+0 
;COM.c,43 :: 		PORTB = 0x00;
	CLRF        PORTB+0 
;COM.c,44 :: 		LATB = 0x0F;
	MOVLW       15
	MOVWF       LATB+0 
;COM.c,45 :: 		TRISB0_bit = 0;
	BCF         TRISB0_bit+0, BitPos(TRISB0_bit+0) 
;COM.c,46 :: 		TRISB1_bit = 0;
	BCF         TRISB1_bit+0, BitPos(TRISB1_bit+0) 
;COM.c,47 :: 		TRISB2_bit = 0;
	BCF         TRISB2_bit+0, BitPos(TRISB2_bit+0) 
;COM.c,48 :: 		TRISB3_bit = 0;
	BCF         TRISB3_bit+0, BitPos(TRISB3_bit+0) 
;COM.c,50 :: 		PORTD = 0x00;
	CLRF        PORTD+0 
;COM.c,51 :: 		LATD = 0x00;
	CLRF        LATD+0 
;COM.c,52 :: 		TRISD1_bit = 0;
	BCF         TRISD1_bit+0, BitPos(TRISD1_bit+0) 
;COM.c,53 :: 		TRISD0_bit = 0;
	BCF         TRISD0_bit+0, BitPos(TRISD0_bit+0) 
;COM.c,54 :: 		TRISD2_bit = 0;
	BCF         TRISD2_bit+0, BitPos(TRISD2_bit+0) 
;COM.c,55 :: 		TRISD3_bit = 0;
	BCF         TRISD3_bit+0, BitPos(TRISD3_bit+0) 
;COM.c,57 :: 		RD0_bit = 1;
	BSF         RD0_bit+0, BitPos(RD0_bit+0) 
;COM.c,58 :: 		RD1_bit = 1;
	BSF         RD1_bit+0, BitPos(RD1_bit+0) 
;COM.c,59 :: 		RD2_bit = 1;
	BSF         RD2_bit+0, BitPos(RD2_bit+0) 
;COM.c,60 :: 		RD3_bit = 1;
	BSF         RD3_bit+0, BitPos(RD3_bit+0) 
;COM.c,64 :: 		PORTE = 0x00;
	CLRF        PORTE+0 
;COM.c,65 :: 		LATE = 0x07;
	MOVLW       7
	MOVWF       LATE+0 
;COM.c,66 :: 		TRISE0_bit = 0;
	BCF         TRISE0_bit+0, BitPos(TRISE0_bit+0) 
;COM.c,67 :: 		TRISE1_bit = 0;
	BCF         TRISE1_bit+0, BitPos(TRISE1_bit+0) 
;COM.c,68 :: 		TRISE2_bit = 0;
	BCF         TRISE2_bit+0, BitPos(TRISE2_bit+0) 
;COM.c,70 :: 		UART1_Init(9600);
	BSF         BAUDCON+0, 3, 0
	MOVLW       2
	MOVWF       SPBRGH+0 
	MOVLW       8
	MOVWF       SPBRG+0 
	BSF         TXSTA+0, 2, 0
	CALL        _UART1_Init+0, 0
;COM.c,71 :: 		delay_ms(100);
	MOVLW       3
	MOVWF       R11, 0
	MOVLW       138
	MOVWF       R12, 0
	MOVLW       85
	MOVWF       R13, 0
L_main0:
	DECFSZ      R13, 1, 1
	BRA         L_main0
	DECFSZ      R12, 1, 1
	BRA         L_main0
	DECFSZ      R11, 1, 1
	BRA         L_main0
	NOP
	NOP
;COM.c,72 :: 		while(1)
L_main1:
;COM.c,74 :: 		dat = UART1_Read();
	CALL        _UART1_Read+0, 0
	MOVF        R0, 0 
	MOVWF       _dat+0 
;COM.c,76 :: 		if ( dat ==  pc_led_on1)
	MOVF        R0, 0 
	XORLW       65
	BTFSS       STATUS+0, 2 
	GOTO        L_main3
;COM.c,78 :: 		RE0_bit = 0;
	BCF         RE0_bit+0, BitPos(RE0_bit+0) 
;COM.c,79 :: 		UART1_Write(mcu_led_on1);
	MOVLW       49
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,80 :: 		}
L_main3:
;COM.c,82 :: 		if ( dat == pc_led_of1)
	MOVF        _dat+0, 0 
	XORLW       72
	BTFSS       STATUS+0, 2 
	GOTO        L_main4
;COM.c,84 :: 		RE0_bit = 1;
	BSF         RE0_bit+0, BitPos(RE0_bit+0) 
;COM.c,85 :: 		UART1_Write(mcd_led_of1);
	MOVLW       54
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,86 :: 		}
L_main4:
;COM.c,88 :: 		if ( dat ==  pc_led_on2)
	MOVF        _dat+0, 0 
	XORLW       66
	BTFSS       STATUS+0, 2 
	GOTO        L_main5
;COM.c,90 :: 		RE1_bit = 0;
	BCF         RE1_bit+0, BitPos(RE1_bit+0) 
;COM.c,91 :: 		UART1_Write(mcu_led_on2)    ;
	MOVLW       50
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,92 :: 		}
L_main5:
;COM.c,94 :: 		if ( dat == pc_led_of2)
	MOVF        _dat+0, 0 
	XORLW       74
	BTFSS       STATUS+0, 2 
	GOTO        L_main6
;COM.c,96 :: 		RE1_bit = 1;
	BSF         RE1_bit+0, BitPos(RE1_bit+0) 
;COM.c,97 :: 		UART1_Write(mcd_led_of2);
	MOVLW       55
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,98 :: 		}
L_main6:
;COM.c,100 :: 		if ( dat ==  pc_led_on3)
	MOVF        _dat+0, 0 
	XORLW       67
	BTFSS       STATUS+0, 2 
	GOTO        L_main7
;COM.c,102 :: 		RE2_bit = 0;
	BCF         RE2_bit+0, BitPos(RE2_bit+0) 
;COM.c,103 :: 		UART1_Write(mcu_led_on3);
	MOVLW       51
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,104 :: 		}
L_main7:
;COM.c,106 :: 		if ( dat == pc_led_of3)
	MOVF        _dat+0, 0 
	XORLW       75
	BTFSS       STATUS+0, 2 
	GOTO        L_main8
;COM.c,108 :: 		RE2_bit = 1;
	BSF         RE2_bit+0, BitPos(RE2_bit+0) 
;COM.c,109 :: 		UART1_Write(mcd_led_of3);
	MOVLW       56
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,110 :: 		}
L_main8:
;COM.c,115 :: 		if ( dat ==  pc_led_on4)
	MOVF        _dat+0, 0 
	XORLW       68
	BTFSS       STATUS+0, 2 
	GOTO        L_main9
;COM.c,117 :: 		if(state1 == 2)
	MOVLW       0
	XORWF       _state1+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main24
	MOVLW       2
	XORWF       _state1+0, 0 
L__main24:
	BTFSS       STATUS+0, 2 
	GOTO        L_main10
;COM.c,118 :: 		delay_ms(2000);
	MOVLW       51
	MOVWF       R11, 0
	MOVLW       187
	MOVWF       R12, 0
	MOVLW       223
	MOVWF       R13, 0
L_main11:
	DECFSZ      R13, 1, 1
	BRA         L_main11
	DECFSZ      R12, 1, 1
	BRA         L_main11
	DECFSZ      R11, 1, 1
	BRA         L_main11
	NOP
	NOP
L_main10:
;COM.c,120 :: 		RD0_bit = 0;
	BCF         RD0_bit+0, BitPos(RD0_bit+0) 
;COM.c,121 :: 		RD1_bit = 0;
	BCF         RD1_bit+0, BitPos(RD1_bit+0) 
;COM.c,122 :: 		UART1_Write(mcu_led_on4) ;
	MOVLW       52
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,123 :: 		state1 = 1;
	MOVLW       1
	MOVWF       _state1+0 
	MOVLW       0
	MOVWF       _state1+1 
;COM.c,124 :: 		}
L_main9:
;COM.c,127 :: 		if ( dat ==  pc_led_on5)
	MOVF        _dat+0, 0 
	XORLW       69
	BTFSS       STATUS+0, 2 
	GOTO        L_main12
;COM.c,129 :: 		if(state1 == 1)
	MOVLW       0
	XORWF       _state1+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main25
	MOVLW       1
	XORWF       _state1+0, 0 
L__main25:
	BTFSS       STATUS+0, 2 
	GOTO        L_main13
;COM.c,130 :: 		delay_ms(2000);
	MOVLW       51
	MOVWF       R11, 0
	MOVLW       187
	MOVWF       R12, 0
	MOVLW       223
	MOVWF       R13, 0
L_main14:
	DECFSZ      R13, 1, 1
	BRA         L_main14
	DECFSZ      R12, 1, 1
	BRA         L_main14
	DECFSZ      R11, 1, 1
	BRA         L_main14
	NOP
	NOP
L_main13:
;COM.c,131 :: 		RD0_bit = 0;
	BCF         RD0_bit+0, BitPos(RD0_bit+0) 
;COM.c,132 :: 		RD1_bit = 1;
	BSF         RD1_bit+0, BitPos(RD1_bit+0) 
;COM.c,133 :: 		UART1_Write(mcu_led_on5) ;
	MOVLW       53
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,134 :: 		state1=2;
	MOVLW       2
	MOVWF       _state1+0 
	MOVLW       0
	MOVWF       _state1+1 
;COM.c,135 :: 		}
L_main12:
;COM.c,138 :: 		if ( dat ==  pc_led_on6)
	MOVF        _dat+0, 0 
	XORLW       70
	BTFSS       STATUS+0, 2 
	GOTO        L_main15
;COM.c,140 :: 		RD0_bit = 1;
	BSF         RD0_bit+0, BitPos(RD0_bit+0) 
;COM.c,141 :: 		RD1_bit = 1;
	BSF         RD1_bit+0, BitPos(RD1_bit+0) 
;COM.c,142 :: 		UART1_Write(mcu_led_on6) ;
	MOVLW       81
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,143 :: 		state1=0;
	CLRF        _state1+0 
	CLRF        _state1+1 
;COM.c,146 :: 		}
L_main15:
;COM.c,152 :: 		if ( dat ==  pc_led_of4)
	MOVF        _dat+0, 0 
	XORLW       76
	BTFSS       STATUS+0, 2 
	GOTO        L_main16
;COM.c,154 :: 		if(state2==2)
	MOVLW       0
	XORWF       _state2+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main26
	MOVLW       2
	XORWF       _state2+0, 0 
L__main26:
	BTFSS       STATUS+0, 2 
	GOTO        L_main17
;COM.c,155 :: 		delay_ms(2000);
	MOVLW       51
	MOVWF       R11, 0
	MOVLW       187
	MOVWF       R12, 0
	MOVLW       223
	MOVWF       R13, 0
L_main18:
	DECFSZ      R13, 1, 1
	BRA         L_main18
	DECFSZ      R12, 1, 1
	BRA         L_main18
	DECFSZ      R11, 1, 1
	BRA         L_main18
	NOP
	NOP
L_main17:
;COM.c,157 :: 		RD2_bit = 0;
	BCF         RD2_bit+0, BitPos(RD2_bit+0) 
;COM.c,158 :: 		RD3_bit = 0;
	BCF         RD3_bit+0, BitPos(RD3_bit+0) 
;COM.c,159 :: 		UART1_Write(mcd_led_of4) ;
	MOVLW       57
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,160 :: 		state2 = 1;
	MOVLW       1
	MOVWF       _state2+0 
	MOVLW       0
	MOVWF       _state2+1 
;COM.c,163 :: 		}
L_main16:
;COM.c,166 :: 		if ( dat ==  pc_led_of5)
	MOVF        _dat+0, 0 
	XORLW       90
	BTFSS       STATUS+0, 2 
	GOTO        L_main19
;COM.c,168 :: 		if(state2 == 1)
	MOVLW       0
	XORWF       _state2+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main27
	MOVLW       1
	XORWF       _state2+0, 0 
L__main27:
	BTFSS       STATUS+0, 2 
	GOTO        L_main20
;COM.c,169 :: 		delay_ms(2000);
	MOVLW       51
	MOVWF       R11, 0
	MOVLW       187
	MOVWF       R12, 0
	MOVLW       223
	MOVWF       R13, 0
L_main21:
	DECFSZ      R13, 1, 1
	BRA         L_main21
	DECFSZ      R12, 1, 1
	BRA         L_main21
	DECFSZ      R11, 1, 1
	BRA         L_main21
	NOP
	NOP
L_main20:
;COM.c,171 :: 		RD2_bit = 0;
	BCF         RD2_bit+0, BitPos(RD2_bit+0) 
;COM.c,172 :: 		RD3_bit = 1;
	BSF         RD3_bit+0, BitPos(RD3_bit+0) 
;COM.c,173 :: 		UART1_Write(mcd_led_of5) ;
	MOVLW       48
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;COM.c,174 :: 		state2 = 2;
	MOVLW       2
	MOVWF       _state2+0 
	MOVLW       0
	MOVWF       _state2+1 
;COM.c,177 :: 		}
L_main19:
;COM.c,180 :: 		if ( dat ==  pc_led_of6)
	MOVF        _dat+0, 0 
	XORLW       77
	BTFSS       STATUS+0, 2 
	GOTO        L_main22
;COM.c,182 :: 		RD2_bit = 1;
	BSF         RD2_bit+0, BitPos(RD2_bit+0) 
;COM.c,183 :: 		RD3_bit = 1;
	BSF         RD3_bit+0, BitPos(RD3_bit+0) 
;COM.c,184 :: 		UART_Write(mcd_led_of6) ;
	MOVLW       73
	MOVWF       FARG_UART_Write__data+0 
	CALL        _UART_Write+0, 0
;COM.c,185 :: 		state2=0;
	CLRF        _state2+0 
	CLRF        _state2+1 
;COM.c,187 :: 		}
L_main22:
;COM.c,189 :: 		}
	GOTO        L_main1
;COM.c,190 :: 		}
L_end_main:
	GOTO        $+0
; end of _main
