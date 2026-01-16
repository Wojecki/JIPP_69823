%cw1
first([X|_], X).

last([X],X).
last([_|T], X):-
    last(T,X).

sum_list([], 0).
sum_list([H|T], Sum):-
    sum_list(T, Sum1),
    Sum is H + Sum1.
%cw2
count_greater([], _, 0).
count_greater([H|T], N, Count):-
    H > N,
    count_greater(T, N, Count1),
    Count is Count1 + 1.

count_greater([H|T], N, Count):-
    H =< N,
    count_greater(T, N, Count).
%cw3
prefix(P, L):-
    append(P, _, L).

suffix(S, L):-
    append(_, S, L).

sublist(Sub, L):-
    append(_, L2, L),
    append(Sub, _, L2).
%cw4
%cw5
replace([], _, _, []).
replace([X|T], X, Y, [Y|T2]) :-
    replace(T, X, Y, T2).
replace([H|T], X, Y, [H|T2]) :-
    H \= X,
    replace(T, X, Y, T2).
%cw6
all_sublists(List, Sub) :-
    append(_, Rest, List),
    append(Sub, _, Rest).
%cw7

is_increasing([]).
is_increasing([_]).
is_increasing([X,Y|T]) :-
    X < Y,
    is_increasing([Y|T]).

sublists(Sub, List) :-
    append(_, Rest, List),
    append(Sub, _, Rest).

longest([L], L).
longest([H1,H2|T], Max) :-
    length(H1, Len1),
    length(H2, Len2),
    (Len1 >= Len2 -> longest([H1|T], Max)
                   ; longest([H2|T], Max)).

increasing_sublist(List, MaxSub) :-
    findall(Sub, (sublists(Sub, List), is_increasing(Sub)), Subs),
    longest(Subs, MaxSub).


%zadania1-4
usun3ost(L,L1):-
    append(L1, [_,_,_],L).

usun3pierw(L, L1) :-
    append([_, _, _], L1, L).

usun3pierw_i_ost(L, L2) :-
    append([_, _, _], Srodek, L),
    append(L2, [_, _, _], Srodek).

parzysta([]).
parzysta([_, _ | T]) :-
    parzysta(T).

nieparzysta([_]).
nieparzysta([_, _ | T]) :-
    nieparzysta(T).
