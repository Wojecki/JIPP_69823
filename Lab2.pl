%zad2
wieksza(X, Y) :-
    X > Y,
    write(X), write(' jest większa od '), write(Y), nl.

wieksza(X, Y) :-
    X < Y,
    write(Y), write(' jest większa od '), write(X), nl.

wieksza(X, Y) :-
    X =:= Y,
    write('Obie liczby są równe: '), write(X), nl.


maks(X, Y, X) :- X >= Y.
maks(X, Y, Y) :- Y > X.

czyParz(X) :-
    0 is X mod 2,
    write('Liczba którą podałeś jest parzysta').

czyParz(X) :-
    1 is X mod 2,
    write('Liczba którą podałeś jest nie parzysta').

%zad3

silnia(0, 1).
silnia(N, F) :-
    N > 0,
    N1 is N - 1,
    silnia(N1, F1),
    F is N * F1.


suma_do_n(0, 0).       
suma_do_n(N, S) :-
    N > 0,
    N1 is N - 1,
    suma_do_n(N1, S1),
    S is N + S1.

fib(0, 0).
fib(1, 1).
fib(N, F) :-
    N > 1,
    N1 is N - 1,
    N2 is N - 2,
    fib(N1, F1),
    fib(N2, F2),
    F is F1 + F2.


nwd(A, 0, A) :- A > 0.
nwd(A, B, D) :-
    B > 0,
    R is A mod B,
    nwd(B, R, D).


%zad4
%nazwa, cena, ilosc
produkt(jabłko, 2.50, 10).
produkt(banan, 3.00, 5).
produkt(pomarańcza, 4.50, 8).
produkt(marchew, 1.20, 15).
produkt(ziemniak, 2.00, 20).
produkt(truskawka, 5.00, 7).
produkt(mleko, 3.50, 12).
produkt(chleb, 4.20, 6).

wartość_produktu(Nazwa, W) :-
    produkt(Nazwa, Cena, Ilosc),
    W is Cena * Ilosc.

wartość_magazynu(W) :-
    findall(V, (produkt(_, C, I), V is C*I), Lista),
    sum_list(Lista, W).


drogi_produkt(Nazwa) :-
    produkt(Nazwa, Cena, _),
    Cena > 4.

%zad5
%pracownik(imie, podstawa, premia)
pracownik(jan, 4800, 500).
pracownik(ania, 5200, 600).
pracownik(bartek, 4500, 700).
pracownik(magda, 6000, 800).
pracownik(kasia, 4000, 300).

brutto(Imie, B):-
    pracownik(Imie, Podstawa, Premia),
    B is Podstawa + Premia.

podatek17(Imie, T) :-
    brutto(Imie, B),
    T is B * 0.17.

netto(Imie, N) :-
    brutto(Imie, B),
    podatek17(Imie, T),
    N is B - T.

czy_zarabia_wiecej(X, Y, X) :-
    netto(X, NX),
    netto(Y, NY),
    NX > NY.

czy_zarabia_wiecej(X, Y, Y):-
    netto(X, NX),
    netto(Y, NY),
    NX < NY.

czy_zarabia_wiecej(X, Y, rowne) :-
    netto(X, NX),
    netto(Y, NY),
    NX =:= NY.
