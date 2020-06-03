FROM node:lts as build

WORKDIR /app
COPY "Sticker.ClientApp/" .

RUN npm install
RUN npm run-script build

FROM nginx:stable
COPY --from=build /app/dist /app
COPY static.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
EXPOSE 443