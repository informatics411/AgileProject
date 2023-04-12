# AgileProject
Game Finder App v2
Minimal Viable Project: 
An application that allows the user to add, delete, and update games in a game database. Users will be able search game titles by name, Game System, and genre. Est. 20 work-hrs.

User Stories(5-10):
As a gamer, I want a database where I can store my games
Acceptance Criteria:
When a game is added, it shows up in the Database.
If game is not added, error is returned “Game Not Added”
When a SearchByTitle is initiated, returns matching game
When a SearchGameSystem is initiated, returns matching games
When a SearchByGenre is initiated, returns matching games
In cases of No Match, return an error “No Game Found”

1 Task: Create an AddGame method to the Database (REQUIRE all props)
2 Task: Create a SearchByTitle method within the Database 
2 Task: Create a SearchByGameSystem method within the Database
2 Task: Create a SearchByGenre within the Database


As a gamer, I want a database where I can manage all my games
Acceptance Criteria:
When updating game information the gamer would be able to update all properties of the Game
If the changes were made, return true
When a game is removed, it no longer shows up in the Database, return ok
If game is not removed, error is returned “Game Not Removed”

2 Task: Create an UpdateGame method 
1 Task: Create a RemoveGame method to the Database


As a gamer, I want to be able to manage the GameSystems in the collection
Acceptance Criteria:
When a GameSystem is added, it shows up in the Database.
If GameSystem is not added, error is returned “GameSystem Not Added”
When updating GameSystem information the gamer would be able to update the name of the GameSystem
If the changes were made, return true

1 Task: Create an AddGameSystem method within the Database
2 Task: Create an UpdateGameSystem method within the Database
1 Task: Comment on NoDelete GameSystem

As a gamer, I want to be able to manage the Genres in the collection
Acceptance Criteria:
When a Genre is added, it shows up in the Database.
If Genre is not added, error is returned “Genre Not Added”
When updating Genre information the gamer would be able to update the name of the Genre
If the changes were made, return true

1 Task: Create an AddGenre method within the Database
2 Task: Create an UpdateGenre method within the Database
1 Task: Comment on NoDelete Genre

I want to be able to search for all the Multiplayer games 
As a gamer, I want to be able to highlight my favorite games in my collection
As a gamer, I want to see a ListOfAllGames
As a gamer, I want to see a ListOfAllGameSystems
As a gamer, I want to see a ListOfAllGenres
