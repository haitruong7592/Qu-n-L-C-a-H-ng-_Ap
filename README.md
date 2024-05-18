# Qu-n-L-C-a-H-ng-_Ap
# Simpflex

## 入手ファイル
- tt_thi_etc.backup
	- postgreSQLのpg_dumpファイル

## docker PostgreSQLに構築

### docker-compose.yml
- POSTGRES_USER: simpflex(固定)
- POSTGRES_PASSWORD: (任意)
- POSTGRES_DB: simpflex(固定)
```
# Use postgres/example user/password credentials
version: '3.9'

services:

  db:
    image: postgres:9.3.13
    restart: always
    # set shared memory limit when using docker-compose
    shm_size: 128mb
    # or set shared memory limit when deploy via swarm stack
    #volumes:
    #  - type: tmpfs
    #    target: /dev/shm
    #    tmpfs:
    #      size: 134217728 # 128*2^20 bytes = 128Mb
    environment:
      POSTGRES_USER: simpflex
      POSTGRES_PASSWORD: qten
      POSTGRES_DB: simpflex
    ports:
      - 5432:5432
    volumes:
      - ./simpflex/dump:/usr/src/simpflex
      - ./simpflex/initdb.d:/docker-entrypoint-initdb.d
      
  adminer:
    image: adminer
    restart: always
    ports:
      - 8054:8080
```

### docker up
- dumpファイルからSQLファイルを抽出するため、一度upする
```
docker compose up -d
```

### dumpファイルからTable定義だけを抽出

- ホスト側で実行する
- dumpファイルを下記に配置した場合、
	- `./simpflex/tt_thi_etc.backup`
		- docker-compose.ymlからの相対パス
```
$ sudo docker compose exec -iT db pg_restore --schema-only -f /usr/src/simpflex/tt_thi_etc.backup-tableonly.sql < ./simpflex/tt_thi_etc.backup
```
- 抽出したSQLファイルをrenameして、下記に配置
	- `./simpflex/initdb.d/02-tt_thi_etc.backup-tableonly.sql`
		- docker-compose.ymlからの相対パス

### dumpファイルからデータだけを抽出

- ホスト側で実行する
- dumpファイルを下記に配置した場合、
	- `./simpflex/tt_thi_etc.backup`（docker-compose.ymlからの相対パス）
```
$ sudo docker compose exec -iT db pg_restore --data-only -f /usr/src/simpflex/tt_thi_etc.backup-dataonly.sql < ./simpflex/tt_thi_etc.backup
```
- 抽出したSQLファイルをrenameして、下記に配置
	- `./simpflex/initdb.d/05-tt_thi_etc.backup-dataonly.sql`
		- docker-compose.ymlからの相対パス
  - データを復元する場合のみ

### Create Schemaファイル作成
- docker版postgreSQLは、createdbでschemaが作成されないため、db構築後にSQLファイルを実行して、schemaを自動作成する
- 下記ファイルを作成する
	- `./simpflex/initdb.d/01-create_schema.sql`
		- docker-compose.ymlからの相対パス
```
\c simpflex
CREATE SCHEMA simpflex;

ALTER USER postgres SET search_path TO simpflex;
```

### docker down
- initdb.dbを実行するため、作成したDBを削除
```
docker compose down
```

### docker up
- DB再構築
```
docker compose up -d
```

### docker logs
- 正常終了したか確認
  - 全てのSQLの実行が終了するまで、adminerでの参照できない
```
docker compose logs -f
```

### adminer
```
http://localhost:8054/
```
