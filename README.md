# Gibson-Knight
Gibson Yöntemi ve Knight Yönetimi ile Bilgisayar Hızını Bulma

## Uygulama 1: 
#### MOV AX, Ph
#### MOV BX, Qh
#### MOV BX
#### MOV BX, AX
#### MOV CX, DX
#### MOV AX, Rh
#### MOV DX, Sh
#### MUL DX
#### ADD AX, BX
#### MOV [D1], AX
#### ADC BX, CX
#### ADC CX, DX
#### MOV [D1+2], DX
#### MOV AX, 0000h
#### ADC AX, AX
#### MOV [D1+4], AX

Verilen metin dosyası içindeki Assembly programını text 
dosyasından okuyarak (komutların ilk üç kelimesini okutmanız 
yeterli olacaktır), Gibson yöntemine göre mikroişlemcinin hızını 
hesaplayan programı istediğiniz bir programlama dili sentaksını 
kullanarak kodlayınız. Bilgisayar frekansı 1 GHz - 5 GHz arasında 
(0,1 aralıklarla artırılarak değiştirilebilecek) ve performans 
hesaplamasında kullanılacak programın komut kütüphanesinin aşağıdaki 
tablo ile kısıtlı olacağı varsayılacaktır

|Komut  | Ağırlık | CLK Sayısı|
|------------- | -------------|
|MOV  | 0.2 | 2|
|MUL  | 0.4 | 5|
|ADD | 0.3 | 3|
|ADC  | 0.3 | 3|

## Uygulama 2: 

#### MOV AX, 0
#### MOV CX, 0
#### MOV BX, OFFSET DIZI
#### MOV AX, SONUC
#### MUL BX
#### ADD AX, [BX]
#### ADD CX, CX
#### MOV SONUC, AX
#### ADC AX, AX
#### MUL AX
#### ADD BX, 2
#### INC CX
#### CMP CX, 6
#### ADC DX, CX
#### MOV AX, 0000h

Verilen metin dosyası içindeki Assembly programını text dosyasından 
okuyarak (komutların ilk üç kelimesini okutmanız yeterli olacaktır), 
MIPS yöntemine göre mikroişlemcinin hızını hesaplayan programı istediğiniz 
bir programlama dili sentaksını kullanarak kodlayınız. Bilgisayar frekansı 
1 GHz - 5 GHz arasında (0,1 aralıklarla artırılarak değiştirilebilecek) ve 
performans hesaplamasında kullanılacak programın komut kütüphanesinin aşağıdaki 
tablo ile kısıtlı olacağı varsayılacaktır. 

|Komut  | CLK Sayısı|
------------- | -------------|
|MOV | 2|
|MUL | 4|
|ADD | 2|
|ADC  | 2|
|INC  | 2|
|CMP  | 3|

