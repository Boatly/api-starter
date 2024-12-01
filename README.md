# .NET Starter API

A starter template for a .NET API with authentication, controllers and services

## Setup

Create a `.env` file and create the following entries:

```
SUPABASE_ISSUER="https://{your supabase project id}.supabase.co/auth/v1"
SUPABASE_SECRET="{your supabase secret}"
```

## Running the project

Click Run and Debug from the VS Code toolbar

View your API on:

```
http://localhost:5274/swagger/index.html
```

When you modify your endpoints, import the API in the Vue client application by running in the client project:

```
pnpm gen-api
```
