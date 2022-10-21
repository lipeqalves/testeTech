<template>
    <v-card class="pa-6">
   <!-- <v-text-field
        v-model="clientes.name"
        :rules="nameRules"
        label="Name"
        required
      ></v-text-field>
      {{clientes.name}}-->
  <v-btn color="success" class="mr-4" @click="buscar"> Buscar </v-btn>
    <v-simple-table dark>
      <template v-slot:default>
        <thead>
          <tr>
            <th class="text-left">
              ID
            </th>
            <th class="text-left">
              Nome
            </th>
            <th class="text-left">
              Email
            </th>
            <th class="text-left">
              Telefone
            </th>
            <th class="text-left">
              CNH
            </th>
           
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="item in cliente"
            :key="item.cnh"
          >
            <td>{{ item.id }}</td>
            <td>{{ item.name }}</td>
            <td>{{ item.email }}</td>
            <td>{{ item.telefone }}</td>
            <td>{{ item.cnh }}</td>
            
          </tr>
        </tbody>
      </template>
    </v-simple-table>
    
</v-card>
  </template>
  <script>

  export default {

    data: () => ({
    /*valid: true,
    clientes: {
      name: "",
    },*/
    
    nameRules: [
      (v) => !!v || "Name is required",
      (v) => (v && v.length > 3) || "nome tem que ter mais de 3 caracteres",
    ],
    cliente: [
          {
            id:"",
            name: '',
            email: '',
            telefone: "",
            cnh:'',
           
          },
          
        ],
        veiculo: [
          {
            id:"",
            veiculo: "",
            placa: "",
            modelo: "",
            ano: "",
            cor: "",
          },
        ],
       
        
       
  }),
methods: {
    async buscar() {
     
      try {
        
        var responseClientes = await this.$axios({
          method: "GET",
          url: "https://localhost:7280/Clientes/",
           
        });
        this.cliente = responseClientes.data;

        var responseVeiculo = await this.$axios({
          method: "GET",
          url: "https://localhost:7280/Veiculo/",
           
        });
        this.veiculo = responseVeiculo.data;
        
      } catch {}
      
    },
  },
   
  }
</script>