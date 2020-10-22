<template>
  <div>
    <!-- navigation on mobile -->
    <mobile-sidebar />
  
    <!-- navigation on desktop  -->
    <desktop-sidebar />
  </div>
<!-- </div> -->

</template>

<script>
import MobileSidebar from './mobileSideBar'
import DesktopSidebar from './desktopSideBar'
export default {
  components: {
    MobileSidebar,
    DesktopSidebar
  }
}
</script>