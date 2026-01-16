rodzic(marcin, ania).
rodzic(zofia, marcin).

rodzic(andrzej, jan).
rodzic(jan, mikołaj).

rodzic(ewa, kasia).
rodzic(ewa, marcin).

kobieta(ania).
kobieta(zofia).
kobieta(ewa).
kobieta(kasia).

mężczyzna(marcin).
mężczyzna(jan).
mężczyzna(andrzej).
mężczyzna(mikołaj).

potomek(Y,X) :-
    rodzic(X, Y).

matka(X,Y) :-
    rodzic(X, Y),kobieta(X).

dziadkowie(X,Z):-
    rodzic(X,Y),rodzic(Y,Z).

siostra(X,Y):-
    kobieta(X),
    rodzic(R,X),
    rodzic(R,Y),
    X \= Y.

brat(X,Y):-
    rodzic(R,X),
    rodzic(R,Y),
    mężczyzna(X),
    X \= Y.