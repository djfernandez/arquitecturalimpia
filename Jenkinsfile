pipeline {
  agent any
  stages {
    stage('Docker 01') {
      steps {
        sh 'sudo docker build -t dev_limpia_net:01 -f CleanArchitecture.API/Dockerfile .'
      }
    }

    stage('Docker 02') {
      steps {
        sh 'sudo docker run --name limpiaDevC --detach --privileged --network bridge --publish 2050:80 dev_limpia_net_net:01'
      }
    }

  }
}