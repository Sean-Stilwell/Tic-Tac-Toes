%possible win combinations
win(Game,Player):- Game = [Player,Player,Player,_,_,_,_,_,_].
win(Game,Player):- Game = [Player,_,_,Player,_,_,Player,_,_].
win(Game,Player):- Game = [Player,_,_,_,Player,_,_,_,Player].
win(Game,Player):- Game = [_,Player,_,_,Player,_,_,Player,_].
win(Game,Player):- Game = [_,_,Player,_,Player,_,Player,_,_].
win(Game,Player):- Game = [_,_,Player,_,_,Player,_,_,Player].

%updates the board based on the postition entered
playerupdate([1,B,C,D,E,F,G,H,I], 1, [x,B,C,D,E,F,G,H,I]).
playerupdate([A,2,C,D,E,F,G,H,I], 2, [A,x,C,D,E,F,G,H,I]).
playerupdate([A,B,3,D,E,F,G,H,I], 3, [A,B,x,D,E,F,G,H,I]).
playerupdate([A,B,C,4,E,F,G,H,I], 4, [A,B,C,x,E,F,G,H,I]).
playerupdate([A,B,C,D,5,F,G,H,I], 5, [A,B,C,D,x,F,G,H,I]).
playerupdate([A,B,C,D,E,6,G,H,I], 6, [A,B,C,D,E,x,G,H,I]).
playerupdate([A,B,C,D,E,F,7,H,I], 7, [A,B,C,D,E,F,x,H,I]).
playerupdate([A,B,C,D,E,F,G,8,I], 8, [A,B,C,D,E,F,G,x,I]).
playerupdate([A,B,C,D,E,F,G,H,9], 9, [A,B,C,D,E,F,G,H,x]).

computerupdate([1,B,C,D,E,F,G,H,I], 1, [o,B,C,D,E,F,G,H,I]).
computerupdate([A,2,C,D,E,F,G,H,I], 2, [A,o,C,D,E,F,G,H,I]).
computerupdate([A,B,3,D,E,F,G,H,I], 3, [A,B,o,D,E,F,G,H,I]).
computerupdate([A,B,C,4,E,F,G,H,I], 4, [A,B,C,o,E,F,G,H,I]).
computerupdate([A,B,C,D,5,F,G,H,I], 5, [A,B,C,D,o,F,G,H,I]).
computerupdate([A,B,C,D,E,6,G,H,I], 6, [A,B,C,D,E,o,G,H,I]).
computerupdate([A,B,C,D,E,F,7,H,I], 7, [A,B,C,D,E,F,o,H,I]).
computerupdate([A,B,C,D,E,F,G,8,I], 8, [A,B,C,D,E,F,G,o,I]).
computerupdate([A,B,C,D,E,F,G,H,9], 9, [A,B,C,D,E,F,G,H,o]).

%starts the game
newgame:- gamerules,playermove([1,2,3,4,5,6,7,8,9],[1,2,3,4,5,6,7,8,9]).

%Checks for a cats game
cats(Moves):-
  length(Moves, X),
  X=1,
  write('The game has ended in a tie').

%shows the Board
display([A,B,C,D,E,F,G,H,I]) :-
  nl,write([A,B,C]),nl,
  write([D,E,F]),nl,
  write([G,H,I]),nl.

%Brief rule explaination
gamerules:-
write('To make a move type the postition of the square'),nl,
write([1,2,3]),nl,
write([4,5,6]),nl,
write([7,8,9]),nl.

%player move checks to make sure the computer has not won
playermove(Game,Moves):- win(Game,o),display(Board),write('You lose'),!.
playermove(Board,Moves):-
  nl,write('Players turn'),
  display(Board),
  read(N),
  member(N,Moves),
  %removes the move from the options list
  delete(Moves,N,Remaining),
  playerupdate(Board,N,NewBoard),
  not(cats(Moves)),
  computermove(NewBoard,Remaining).

%Starting computers move checks if player has won
computermove(Game,Moves):- win(Game,x),display(Board),write('You win'),!.
computermove(Board,Moves):-
  nl,write('Computers turn'),
  %selects a move from the list of options
  random_member(Result,Moves),
  delete(Moves,Result,Remaining),
  computerupdate(Board,Result,NewBoard),
  display(NewBoard),
  not(cats(Moves)),
  playermove(NewBoard,Remaining).