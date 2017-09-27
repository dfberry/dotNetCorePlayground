#  $ docker build --no-cache -t dfberry/dotnetcorelatest .
#  $ docker run -d -v /Users/dfberry/repos/dotNetCorePlayground:/usr/repos/dotNetCorePlayground dfberry/dotnetcorelatest 
#  $ docker exec -it <container> bash
# 
# > dotnet build
# > dotnet run

FROM microsoft/dotnet:latest

EXPOSE 3000-3005:3000-3005
WORKDIR /usr

CMD tail -f /dev/null
