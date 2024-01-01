xor bx, bx
mov ds, bx

inicio:
mov ah, 0x0e
mov bx, meuNome
add bx, 0x7c00
add bx, cx
mov al, [bx]
inc cx
cmp cx, 0x06
int 0x10
jne inicio

meuNome: db "Felipe"
times 510 - ($ - $$) db 0x00
dw 0xAA55
