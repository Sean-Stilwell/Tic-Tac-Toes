#lang racket

;; Coded by Sean Stilwell

;; Code to display the board
(define (show-board board)
    (newline)
    (display (car board))
    (display (cadr board))
    (display (caddr board))
    (newline)
    (display (car (cdddr board)))
    (display (cadr (cdddr board)))
    (display (caddr (cdddr board)))
    (newline)
    (display (car(cdddr (cdddr board))))
    (display (cadr(cdddr (cdddr board))))
    (display (caddr(cdddr (cdddr board))))
    (newline)
)

(define (player-move board win-combo)
    ;;checks for a cats game
    (check-cats board)
    ;;checks is a win has occured
    (check-win win-combo)
    (newline)
    (display "Player Turn") (newline)
    ;;Get the player to enter in a move
    (define move (select-move board))
    ;;Updates the game board
    (define board-update (replace move 'x board))
    ;;Updates win combinations
    (define update-win (replace move 'x win-combo))
    (show-board board-update)
    ;;goes to computers turn
    (computer-move board-update update-win)
)

(define (computer-move board win-combo)
    (check-cats board)
    (check-win win-combo)
    (newline)
    (display "Computer Turn") (newline)
    ;;creates a random move for the computer
    (define move (rand-move board))
    (define update-win (replace move 'o win-combo))
    (define board-update (replace move 'o board))
    (show-board board-update)
    (player-move board-update update-win)
)


(define (check-cats ls)
    ;;if no moves are left then it is a cats game
    (if (moves-left ls)
        '()
        ((display "No moves remain") (exit)) 
    )
)

;;checks if any position numbers remain on the board
(define (moves-left ls)
    (if (null? ls)
        #f
        (if (number? (car ls))
            #t
            (moves-left (cdr ls))
        )
    )
)

;;checks if any wins have occured
(define (check-win ls)
    (if (member '(x x x) ls)
        ((display "You have won!")(exit))
        (if(member '(o o o) ls)
            ((display "You have lost")(exit))
            '()
        )
    )
)

;;replaces move positions with x or o depending on the player
(define (replace var player ls)
    (if (null? ls)
        '()
        ;;checks if it is a nested list
        ;;since the win-combo is a list of lists
        (if (list? (car ls))
            (cons (replace var player (car ls))        
                (replace var player (cdr ls)))
            (if (equal? var (car ls))
                (cons player (replace var player (cdr ls)))
                (cons (car ls) (replace var player (cdr ls)))
            )
        )
    )
)

(define (rand-move board)
  ;;gets a random number from 0 to 9
    (define move (random 9))
    ;;if the number is not a possible move it picks again
    (if (not(member move board))
        (rand-move board)
        move
    )
)

(define (select-move board)
    (newline)
    ;;asks player to enter a move
    (display "Enter a position on the board: ")
    (define move (read))
    ;;if the move is invalid it gives the option to pick again
    (if (not(member move board))
        (select-move board)
        move
    )
)

;;brief explanation of how to play
(define (play board win-combo)
    (display "Enter a number on the board to play in that position.")
    (show-board board)
    (player-move board win-combo)
)

;;starts the game
(define start
    (play '(0 1 2 3 4 5 6 7 8) '((0 1 2) (3 4 5) (6 7 8) (0 3 6) (1 4 7) (2 5 8) (0 4 8) (2 4 6))))