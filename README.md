# Algo

Run simple console app using docker compose

```bash
# starting container
docker compose up -d

# run Program.cs
docker container exec -it dotnetsdk dotnet run

# docker compose up -d --force-recreate && docker container logs -f --tail 50 dotnetsdk
```
