<template>
    <v-card class="pa-6">
        <v-toolbar color="white" flat>
            <v-btn icon light>
                <v-icon color="grey darken-2"> mdi-arrow-left </v-icon>
            </v-btn>

            <v-toolbar-title class="grey--text text--darken-4">
                Cadastro
            </v-toolbar-title>

            <v-spacer></v-spacer>
        </v-toolbar>
        <v-form ref="form" v-model="valid" lazy-validation class="ml-4">
            <v-card-title class="headline"> Cadastro Cliente </v-card-title>

            <v-text-field v-model="clientes.name" :rules="nameRules" label="Name" required></v-text-field>

            <v-text-field v-model="clientes.email" :rules="emailRules" label="E-mail" required></v-text-field>

            <v-text-field v-model="clientes.telefone" label="Telefone" required></v-text-field>

            <v-text-field v-model="clientes.cnh" label="CNH" required></v-text-field>

            <v-card-title class="headline"> Cadastro Veiculo </v-card-title>

            <v-text-field v-model="veiculos.veiculo" label="Veiculo" required></v-text-field>

            <v-text-field v-model="veiculos.placa" label="Placa" required></v-text-field>

            <v-text-field v-model="veiculos.modelo" label="Modelo" required></v-text-field>

            <v-text-field v-model="veiculos.ano" label="Ano" required></v-text-field>

            <v-text-field v-model="veiculos.cor" label="cor" required></v-text-field>

            <v-btn color="success" class="mr-4" @click="enviar"> Enviar </v-btn>
        </v-form>
        <v-footer class="mt-12"></v-footer>
    </v-card>

</template>
<script>
export default {
    data: () => ({
        valid: true,
        clientes: {
            name: "",
            email: "",
            telefone: "",
            cnh: "",
        },
        veiculos: {
            veiculo: "",
            placa: "",
            modelo: "",
            ano: "",
            cor: "",
        },
        nameRules: [
            (v) => !!v || "Name is required",
            (v) => (v && v.length > 3) || "nome tem que ter mais de 3 caracteres",
        ],
        emailRules: [
            (v) => !!v || "E-mail is required",
            (v) => /.+@.+\..+/.test(v) || "formato do email teste@test.com.br",
        ],

    }),

    methods: {
        async enviar() {
           
            try {
                var response = await this.$axios({
                    method: "POST",
                    url: "https://localhost:7280/Clientes",
                    data: this.clientes,
                });

                var responseVeiculo = await this.$axios({
                    method: "POST",
                    url: "https://localhost:7280/veiculo",
                    data: this.veiculos,
                });

            } catch { }
        },
    },
};
</script>
