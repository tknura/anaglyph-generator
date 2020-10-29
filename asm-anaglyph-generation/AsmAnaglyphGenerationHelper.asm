.686
.model 
.data

wid	dd 0
wsp1 dd 0.299
wsp2 dd 0.587
wsp3 dd 0.114
.CODE


anaglifs_ASM proc; 
	;mov r12,[rcx];in bitmap left
	;mov r13,[rcx+8];in bitmap right
	;mov r14,[rcx+16];out bitmap
;
	;mov eax,[rdx+12] ;width
	;mov wid,eax
;
	;xor rax,rax
;
	;mov rbx,3 
	;mov rax,[rdx+4]
	;sub rax,[rdx]
	;mul rbx
	;mul wid
	;mov r15,rax ; size in r15
	;
	;pinsrq xmm15, rax, 0
	;pinsrq xmm15, rdx, 1
;
;
	;pinsrd xmm0, wsp3, 2
	;pinsrd xmm0, wsp2, 1
	;pinsrd xmm0, wsp1, 0
;
	;licz:
	;sub r15,3
	;jl exit
;
;
	;movd xmm1,dword ptr[r12]
;
	;PUNPCKLBW xmm1,xmm4;
	;PUNPCKLWD xmm1,xmm4;
	;CVTDQ2PS xmm1,xmm1
;
	;movd xmm2,dword ptr[r13];
	;PUNPCKLBW xmm2,xmm4;
	;PUNPCKLWD xmm2,xmm4;
	;CVTDQ2PS xmm2,xmm2
;
	;mulps xmm1,xmm0	;mnozenie przez wspolczynniki lewej
	;mulps xmm2,xmm0	;mnozenie przez wspolczynniki prawej
;
	;haddps xmm1,xmm3
	;haddps xmm1,xmm3
;
	;haddps xmm2,xmm3
	;haddps xmm2,xmm3
;
	;movd rax,xmm2
;
	;pinsrd xmm1, eax, 1
	;pinsrd xmm1, eax, 2
;
	;cvttps2dq xmm1,xmm1
;
	;packssdw xmm1,xmm3
	;packuswb xmm1,xmm3
;
	;movd dword ptr[r14],xmm1 ;output
;
	;add r12,3
	;add r13,3
	;add r14,3
;
	;jmp licz
;
;exit:
ret;
anaglifs_ASM endp;

END