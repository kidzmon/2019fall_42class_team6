<template lang="html">
  <div class="form">
    <h2>Payment Methods</h2>
    <br>
    <IRPaymentMethodBlank v-if="is_empty"></IRPaymentMethodBlank>
    <div v-else v-for="pid in PIDs" v-bind:key="pid">
      <IRPaymentMethodCard v-bind:PID="pid"></IRPaymentMethodCard>
    </div>
    <br>
    <IRPaymentMethodForm></IRPaymentMethodForm>
  </div>
</template>

<script>
import IRPaymentMethodBlank from './IRPaymentMethodBlank.vue'
import IRPaymentMethodCard from './IRPaymentMethodCard.vue'
import IRPaymentMethodForm from './IRPaymentMethodForm.vue'

export default {
  data(){
    return {
      PIDs: null
    }
  },
  created() {
    if(localStorage.getItem('paymentToken') == ''){
      this.PIDs = []
    }else{
      var paymentToken = JSON.parse(localStorage.getItem('paymentToken'))
      this.PIDs = Object.keys(paymentToken)
    }

  },
  computed: {
    is_empty() {
      return !this.$store.getters.existPaymentMethod
    }
  },
  components: {
    'IRPaymentMethodBlank': IRPaymentMethodBlank,
    'IRPaymentMethodCard': IRPaymentMethodCard,
    'IRPaymentMethodForm': IRPaymentMethodForm
  }
}
</script>

<style lang="css" scoped>
  .form{
    display: inline-block;
    width: 70%;
    text-align: center;
  }
</style>
