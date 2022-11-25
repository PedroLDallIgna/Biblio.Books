FROM mcr.microsoft.com/mssql/server:2019-latest

USER root
RUN mkdir -p /usr/src/app
RUN chown mssql /usr/src/app

USER mssql
WORKDIR /usr/src/app

COPY . /usr/src/app

USER root
RUN chmod +x /usr/src/app/run-initialization.bash

USER mssql
ENV SA_PASSWORD Senha123456!
ENV ACCEPT_EULA Y
ENV MSSQL_PID Express

EXPOSE 1433

CMD ["/bin/bash", "./entrypoint.bash"]
