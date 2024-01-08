pipeline {
  agent any
  stages {
    stage('Docker 01') {
      steps {
        sh 'docker build -t dev_limpia_net:01 -f CleanArchitecture.API/Dockerfile .'
      }
    }

  }
}