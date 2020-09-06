# FirstUnique
Example application written in F# to show off using Optional Types and Pipes to Solve a simple challenge of finding the first unique Character in a String.

## Running Unit Test
Run `dotnet test`

## Run Command line Application
Run `dotnet run --project FirstUnique.CommandLine abc`

## Docker

### Build docker image and use local image
* Build with `docker build . -t first-unique`
* Run wit `docker run first-unique aabbc`