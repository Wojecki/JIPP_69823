lubi(ania, bieganie).
lubi(ania, czytanie).
lubi(bartek, bieganie).
lubi(magda, joga).
lubi(jan, chodzenie).

intensywność(bieganie, wysoki).
intensywność(joga, niski).
intensywność(czytanie, niski).
intensywność(chodzenie, średni).

miejsce(bieganie, na_zewnątrz).
miejsce(joga, wewnątrz).
miejsce(czytanie, wewnątrz).

koszt(bieganie, 5).
koszt(joga, 10).
koszt(czytanie, 0).

pora(bieganie, rano).
pora(joga, rano).
pora(czytanie, wieczór).

wiek(ania, 25).
wiek(jan, 40).

%zainteresowania tańsze niz K
tanie(A):-
    koszt(A,K),
    K =< 5.

%wspólne zainteresowania
wspólne(O1,O2,A):-
    lubi(O1,A),
    lubi(O2,A).

%aktywności o niskim poziomie 
relaks(A):-
    intensywność(A,niski).

%aktywności na zewnątrz
na_zewn(A):-
    miejsce(A, na_zewnątrz).

%pasuuje dla osoby o budżecie =<15
pasuje_dla(Os,A):-
    lubi(Os, A),
    koszt(A,K),
    K=<15.
