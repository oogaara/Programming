mov ah, 0x13
mov al, 0x01
mov bh, 0x00
mov bl, 0xA ;color
mov cx, 10 ;tamanho string
mov dh, 0x01
mov dl, 0x01
mov bp, nome
add bp, 0x7c00 ;inicio do bootloader
int 0x10 ;mostrar na tela

jmp $

nome: db "felipe0x01"
times 510 - ($ - $$) db 0x00
dw 0xAA55
