.data

three byte 3
rmul dd 0.299
gmul dd 0.587
bmul dd 0.114
.code

asmMakeAnagliph proc; 
	; left picture bitmap - rcx
	; right picture bitmap - rdx
	; result bitmap - r8

	xor rax,rax			; clearing rax
	mov rax, [rsp + 40]		 
	sub rax, r9			; end point - start point
	mov r15,rax			; loop amount in r15

	pinsrq xmm15, rax, 0	; load size to xmm15
	pinsrq xmm15, r9, 1	; load start point to xmm15

	add rcx,r9			; move pointer to point at start point in bitmap
	add rdx,r9
	add r8,r9

	pinsrd xmm0, bmul, 2	; load float multiply values to xmm
	pinsrd xmm0, gmul, 1
	pinsrd xmm0, rmul, 0

	licz:
		dec r15				; delete 1 from loop counter
		jl exit				; if less than 0 return

		mov r12, rcx
		and r12, 11			; calculate modulo i % 3
		cmp ah, 0			; check if i % 3 == 0
		je bgValues
		cmp ah, 1			; check if i % 3 == 1
		je bgValues
		cmp ah, 2			; check if i % 3 == 2
		je rValue

		retFromValues:
		inc rcx
		inc rdx
		inc r8
	jmp licz

	bgValues:
		mov r8, [rdx]
	jmp retFromValues

	rValue:
		movd xmm1,dword ptr[rcx-2]		
		CVTDQ2PS xmm1,xmm1				; conversion 32bit int -> float
		mulps xmm1,xmm0					; multiply left bitmap pixel color values with multipliers
		haddps xmm1,xmm3				
		haddps xmm1,xmm3				; summing all xmm1 members

		pinsrd xmm1, eax, 1					
		pinsrd xmm1, eax, 2

		cvttps2dq xmm1,xmm1				; conversion float -> signed word int

		packssdw xmm1,xmm3				
		packuswb xmm1,xmm3				; signed word int -> byte int

		movd dword ptr[r8-2],xmm1			; put xmm1 into result bitmap	
	jmp retFromValues

	exit:
	ret
asmMakeAnagliph endp

end