; Autor: Tomasz Knura INF SSI gr.5 sem.5
; Temat: Generator anaglifów
; Wersja: 1.0
.data

rmul dd 0.299
gmul dd 0.587
bmul dd 0.114
.code

asmMakeAnagliph proc; 

	mov r10,[rsp+40]		; endpoint -> r10
	inc r10
	mov r11,rdx				; right picture -> r11
	mov r12,rcx				; left picture -> r12

	pinsrd xmm0,bmul, 2		; load float multiply values to xmm
	pinsrd xmm0,gmul, 1
	pinsrd xmm0,rmul, 0

	mov rax,r9				; move starting point to rax
	xor rdx,rdx				; clear rdx
	mov ecx,3				; move 3 value to ecx
	div ecx					; i % 3
	cmp edx,1				; i % 3 == 1 (check if G vlue)
	je one
	cmp edx,2				; i % 3 == 2 (check if R value)
	je two

zero:
	mov al,[r11+r9]			; move i into al
    mov [r8+r9],al			; move al into result bitmap value
	inc r9					; increment i
	cmp r9,r10				; check if end of picture
	je return

one:
	mov al,[r11+r9]		
    mov [r8+r9],al
	inc r9
	cmp r9,r10
	je return

two:
	xor rax,rax				; clear rax
	mov al,[r12+r9-2]		; move B value from left pic into al
	movq mm0,rax			; move B value (rax) into mm0
	cvtpi2ps xmm1,mm0		; convert B value from mm0 and load into xmm1
	movlhps xmm1,xmm1		; move lower part of B value (xmm1) into its higher part
	mov al,[r12+r9-1]		; move G value from left pic into al
	shl rax,32				; shift rax by 8 positions to the left 
	mov al,[r12+r9]			; move R value into al
	movq mm0,rax			; move R value with G value (rax) into mm0
	cvtpi2ps xmm1,mm0		; convert R and G value (mm0) and load into xmm1
	mulps xmm1,xmm0			; multiply multipliers from xmm0 with xmm1 values (BGR)
	movhlps xmm3,xmm1		; move higher part of xmm1 (result B part of value) into xmm3 lower part
	unpcklps xmm1,xmm1		; unpack values(R and G part of result) from lower part of xmm1
	movhlps xmm2,xmm1		; move higher part of xmm1 (G part of result value) into xmm2 lower part
	addss xmm1,xmm2			; add all values and store them in xmm1
	addss xmm1,xmm3			
	cvtps2pi mm0,xmm1		; convert result value from xmm1 and load it into mm0
	movd eax,mm0			; move result value (mm0) into eax
	mov [r8+r9],al			; write result value to byte array of result bitmap
	inc r9					; increment i
	cmp r9,r10				; if i != endpoint
	jne  zero		
return:
	ret
asmMakeAnagliph endp

end