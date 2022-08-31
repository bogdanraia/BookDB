const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:46437';

const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/author",
      "/book",
      "/book/add",
      "/genre",
      "/location",
      "/publisher"
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
] 

module.exports = PROXY_CONFIG;
