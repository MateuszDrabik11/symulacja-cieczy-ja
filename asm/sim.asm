segment .data
msg: db "Hello World", 0Ah
len: equ $-msg
segment .text
	global _start

_start:
	mov rax, 1
	mov rdi, 1
	mov rsi, msg
	mov rdx, len
	syscall
    ret
