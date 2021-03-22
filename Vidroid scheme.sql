CREATE TABLE "users" (
  "id" SERIAL PRIMARY KEY,
  "username" varchar UNIQUE,
  "password" varchar,
  "email" varchar UNIQUE,
  "salt" varchar,
  "roles" integer
);

CREATE TABLE "usersContactData" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar,
  "surname" varchar,
  "userId" integer,
  "phoneNumber" varchar UNIQUE
);

CREATE TABLE "places" (
  "id" SERIAL PRIMARY KEY,
  "placeId" integer,
  "height" double,
  "width" double,
  "priceRange" integer,
  "placeType" varchar,
  "cuisine" varchar
);

CREATE TABLE "chainNames" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar UNIQUE
);

CREATE TABLE "favourites" (
  "id" SERIAL PRIMARY KEY,
  "placeId" integer,
  "userId" integer
);

CREATE TABLE "history" (
  "id" SERIAL PRIMARY KEY,
  "userId" integer,
  "placeId" integer,
  "date" timestamp
);

CREATE TABLE "avatars" (
  "id" SERIAL PRIMARY KEY,
  "userId" integer,
  "avatar" varbinary
);

CREATE TABLE "placeSchemes" (
  "id" SERIAL PRIMARY KEY,
  "userId" integer,
  "placeId" integer,
  "placeScheme" varbinary
);

ALTER TABLE "usersContactData" ADD FOREIGN KEY ("userId") REFERENCES "users" ("id");

ALTER TABLE "places" ADD FOREIGN KEY ("placeId") REFERENCES "chainNames" ("id");

ALTER TABLE "favourites" ADD FOREIGN KEY ("placeId") REFERENCES "places" ("id");

ALTER TABLE "favourites" ADD FOREIGN KEY ("userId") REFERENCES "users" ("id");

ALTER TABLE "history" ADD FOREIGN KEY ("userId") REFERENCES "users" ("id");

ALTER TABLE "history" ADD FOREIGN KEY ("placeId") REFERENCES "places" ("id");

ALTER TABLE "avatars" ADD FOREIGN KEY ("userId") REFERENCES "users" ("id");

ALTER TABLE "placeSchemes" ADD FOREIGN KEY ("userId") REFERENCES "users" ("id");

ALTER TABLE "placeSchemes" ADD FOREIGN KEY ("placeId") REFERENCES "places" ("id");
