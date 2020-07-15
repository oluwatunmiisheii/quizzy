<template>
  <div class="container my-5">
    <The-Navigation />
    <nuxt />
    <RegisterModal />
  </div>
</template>

<script>
import TheNavigation from '@/components/Navigation'
import RegisterModal from '@/components/Modals/RegisterModal'
export default {
  components: {
    TheNavigation,
    RegisterModal
  }
}
</script>