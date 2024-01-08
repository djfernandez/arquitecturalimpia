pipeline {
  agent any
  stages {
    stage('Docker 01') {
      steps {
        echo 'Creacion de imagen del proyecto'
        sh 'sudo docker build -t dev_limpia_net:01 -f CleanArchitecture.API/Dockerfile .'
        echo 'Termino la creacion de imagen del proyecto'
      }
    }

    stage('Docker 02') {
      steps {
        echo 'Ejecutar imagen del proyecto'
        sh 'sudo docker run --name limpiaDevC --detach --privileged --network bridge --publish 2050:80 dev_limpia_net:01'
        echo 'Termino de cargar imagen'
      }
    }

  }
}