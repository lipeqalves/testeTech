<template>
  <v-row justify="center" align="center">
    <v-col cols="10" sm="8" md="12">
      <v-card class="logo py-0 d-flex justify-center">
        <v-img height="600"
          src="https://ocinemadavilla.pt/wp-content/uploads/2017/07/Estacionamento-1000x525.png">
        </v-img>
      </v-card>
      <v-card>
        <v-card-actions >
          <v-spacer />
          <v-btn color="primary" nuxt to="/cadastro">
            Cadastre-se
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
export default {
  name: 'Home'
}
</script>
