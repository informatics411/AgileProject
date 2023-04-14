# AgileProject

                                                                        DOCUMENT VERSION 2.3b
Game Finder App
Minimal Viable Project: 
An application that allows the user to add, delete, and update games in a game database. Users will be able search game titles by name, Game System, and genre. Est. 20 work-hrs.

User Stories(5-10):
As a gamer, I want a database where I can store my games

1 Task: Create an AddGame method to the Database (REQUIRE all props)
AC
When a game is added, it shows up in the Database.
If game is not added, error is returned “Game Not Added”
2 Task: Create a SearchByTitle method within the Database 
AC
When a SearchByTitle is initiated, returns matching game
In cases of No Match, return an error “No Game Found”
2 Task: Create a SearchByGameSystem method within the Database
AC
When a SearchGameSystem is initiated, returns matching games
In cases of No Match, return an error “No Game Found”
2 Task: Create a SearchByGenre within the Database
AC
When a SearchByGenre is initiated, returns matching games
In cases of No Match, return an error “No Game Found”


As a gamer, I want a database where I can manage all my games

2 Task: Create an UpdateGame method 
AC
When updating game information the gamer would be able to update all properties of the Game
If the changes were made, return true
1 Task: Create a RemoveGame method to the Database
AC
When a game is removed, it no longer shows up in the Database, return ok
If game is not removed, error is returned “Game Not Removed”


As a gamer, I want to be able to manage the GameSystems in the collection

1 Task: Create an AddGameSystem method within the Database
AC
When a GameSystem is added, it shows up in the Database.
If GameSystem is not added, error is returned “GameSystem Not Added”
2 Task: Create an UpdateGameSystem method within the Database
AC
When updating GameSystem information the gamer would be able to update the name of the GameSystem
If the changes were made, return true
1 Task: Comment on NoDelete GameSystem

As a gamer, I want to be able to manage the Genres in the collection

1 Task: Create an AddGenre method within the Database
AC
When a Genre is added, it shows up in the Database.
If Genre is not added, error is returned “Genre Not Added”
2 Task: Create an UpdateGenre method within the Database
AC
When updating Genre information the gamer would be able to update the name of the Genre
If the changes were made, return true
1 Task: Comment on NoDelete Genre

I want to be able to search for all the Multiplayer games 
As a gamer, I want to be able to highlight my favorite games in my collection
As a gamer, I want to see a ListOfAllGames
As a gamer, I want to see a ListOfAllGameSystems
As a gamer, I want to see a ListOfAllGenres


Order of Operation:
AddGameSystem
UpdateGameSystem
No DeleteGameSystem
AddGenre
UpdateGenre
No DeleteGenre
AddGame
RemoveGame
UpdateGame
SearchGameByTitle
SearchGameByGameSystem
SearchGameByGenre

Trello Link:
https://trello.com/invite/b/WEiCOmFn/ATTI8620475d97574228be4b696d760ed45b88AB4858/agile-project
                                                                        
                                                                         DOCUMENT VERSION 2.3b
