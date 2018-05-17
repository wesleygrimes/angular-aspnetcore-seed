FROM microsoft/aspnetcore-build:2 as build-env
WORKDIR /app

ENV NODE_VERSION 8.11.1
ENV NODE_DOWNLOAD_URL https://nodejs.org/dist/v$NODE_VERSION/node-v$NODE_VERSION-linux-x64.tar.gz

RUN curl -SL "$NODE_DOWNLOAD_URL" --output nodejs.tar.gz \
    && mkdir -p /usr/local/opt/nodejs8 \
    && tar -xzf "nodejs.tar.gz" -C /usr/local/opt/nodejs8 --strip-components=1 \
    && rm nodejs.tar.gz \
    && ln -f -s /usr/local/opt/nodejs8/bin/node /usr/local/bin/node \
    && ln -f -s /usr/local/opt/nodejs8/bin/node /usr/local/bin/nodejs

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/aspnetcore:2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "dotnet-app.dll"]
