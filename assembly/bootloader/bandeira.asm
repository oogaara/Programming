xor ax,ax
mov al, 0x13
int 0x10


; Entry   AH = 0Ch
                ; AL = Pixel color
                ; CX = Horizontal position of pixel
                ; DX = Vertical position of pixel
                ; BH = Display page number (graphics modes with more
                     ; than 1 page)

        ; Return  Nothing

xor ax,ax
xor bx,bx
xor cx, CX
xor dx,dx

verde:
mov ah, 0x0C
mov al, 0x02
inc cx
cmp cx, 106
int 0x10
jl verde
je branco

xor ax, ax
xor cx, cx


branco:
mov ah, 0x0C
mov al, 0x0f
inc cx
cmp cx, 212
int 0x10
jl branco
je vermelho

xor ax, ax
xor cx, cx


vermelho:
mov ah, 0x0C
mov al, 0x04
inc cx
cmp cx, 318
int 0x10
jl vermelho

xor ax,ax
xor cx, cx 

inc dx 
cmp dx, 199
jne verde
je fim 

fim:
jmp $

times 510 - ($ - $$) db 0
dw 0xAA55