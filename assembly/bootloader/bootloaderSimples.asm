xor ax, ax
mov es, ax
mov ds, ax
mov ss ,ax

;Entry   AH    = 13h
;               AL    = Subservice (0-3)
;               BH    = Display page number
;               BL    = Attribute (Subservices 0 and 1)
;               CX    = Length of string
;               DH    = Row position where string is to be written
;               DL    = Column position where string is to be written
;               ES:BP = Pointer to string to write
;
;       Return  Nothing

mov ah, 0x13
mov al, 0x01
mov bl, 0x00
mov bh, 0x00
mov cx, 11
mov dh, 5
mov dl, 0
mov bp, frase
add bp, 0x7c00
int 0x10

jmp $

frase: db "felipe0x01"
times 510 - ($ -$$) db 0
dw 0xaa55
