# Hayvan Bilgilendirme

#Bu kod bugun derste gordugumuz Encapsulation inheritance override gibi konulari yuksek duzeyde anladigimi ve rastgele bir konuda kod yazabildigimi anlatmak icin yazilmistir.
/ Kod clean degil (GUNCELLENECEKTIR)
/OOP'nin essential konularindan Polymorphism gibi konularda koduma entegre edilecektir.

-Bu kod yerine yeni Hayvan_bilmece 2 adli repo acip erd diyagramina kadar cizip ne yapacagimi anlatacagim suan bu kod tamamen psuedo vasfi tasimaktadir.

Hayvanlari buradaki gibi Lions , Fly , Wild ,... gibi kategoriler altinda degerlendirecegim.
```public void class Lion:Animal
   publice Lion(int x, int y, int z):base Animal(x,y,z) {};
```
gibi kalitimlar yaptim cunku Aslanlar ile Animal parametreleri aynidir.
fakat
Animal Sound() adli methodda kendisinin sesi yoktur fakat Animal'a ait olan ve Animaldan kalitim alan herhangi birinin kesinlikle Sound() vardir  ve cogu zaman farklidirlar.
''' public void Sound()'''
### -> Bu polymorphism'e kayiyor o yuzden devam etmedim

Override ornegi yapabilmek icin ToString() methoduna yaptim

``` public override void ToString(){};```
