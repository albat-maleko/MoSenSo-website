module Main

open Browser.Dom

let createElement (tag: string) : HTMLElement =
    document.createElement tag :?> HTMLElement

let createLink (label: string) (href: string) : HTMLLIElement =
    let item = createElement "li" :?> HTMLLIElement
    let anchor = createElement "a" :?> HTMLAnchorElement
    anchor.href <- href
    anchor.textContent <- label
    item.appendChild anchor |> ignore
    item

let createIconButton (iconClass: string) (link: string) : HTMLAnchorElement =
    let anchor = createElement "a" :?> HTMLAnchorElement
    anchor.href <- link
    let icon = createElement "i"
    icon.className <- iconClass
    anchor.appendChild icon |> ignore
    anchor

let renderSite () =
    let root = document.getElementById "app"
    if not (isNull root) then
        root.innerHTML <- ""

        let header = createElement "header"
        header.id <- "header"

        let nav = createElement "nav"
        nav.className <- "container"

        let logo = createElement "div"
        logo.className <- "logo"
        logo.innerHTML <- "<i class=\"fa-solid fa-chart-pie\"></i> MoSenSo<span>Digital<span>Marketing</span>"

        let navLinks = createElement "ul"
        navLinks.className <- "nav-links"
        let homeLink = createLink "Home" "#home"
        let aboutLink = createLink "About" "#about"
        let servicesLink = createLink "Services" "#services"
        let contactLink = createLink "Contact" "#contact"
        navLinks.appendChild homeLink |> ignore
        navLinks.appendChild aboutLink |> ignore
        navLinks.appendChild servicesLink |> ignore
        navLinks.appendChild contactLink |> ignore

        let menuToggle = createElement "div"
        menuToggle.className <- "menu-toggle"
        menuToggle.innerHTML <- "<i class=\"fa-solid fa-bars\"></i>"

        nav.appendChild logo |> ignore
        nav.appendChild navLinks |> ignore
        nav.appendChild menuToggle |> ignore
        header.appendChild nav |> ignore

        let home = createElement "section"
        home.id <- "home"
        home.className <- "box-hero"

        let homeContent = createElement "div"
        homeContent.className <- "box-hero-content container"

        let title = createElement "h1"
        title.innerHTML <- "We Drive <span class=\"highlight\">Digital Growth</span> for Your Business"

        let paragraph = createElement "p"
        paragraph.textContent <- "Transform your online presence with data-driven marketing strategies, SEO, and engaging social media campaigns designed to convert."

        let heroButtons = createElement "div"
        heroButtons.className <- "hero-buttons"

        let auditLink = createElement "a"
        auditLink.className <- "btn btn-primary"
        auditLink.href <- "#contact"
        auditLink.textContent <- "Get a Free Audit"

        let servicesLinkButton = createElement "a"
        servicesLinkButton.className <- "btn btn-secondary"
        servicesLinkButton.href <- "#services"
        servicesLinkButton.textContent <- "Explore Services"

        heroButtons.appendChild auditLink |> ignore
        heroButtons.appendChild servicesLinkButton |> ignore
        homeContent.appendChild title |> ignore
        homeContent.appendChild paragraph |> ignore
        homeContent.appendChild heroButtons |> ignore
        home.appendChild homeContent |> ignore

        let about = createElement "section"
        about.id <- "about"
        about.className <- "box-about container"

        let aboutText = createElement "div"
        aboutText.className <- "about-text"
        let aboutTitle = createElement "h2"
        aboutTitle.textContent <- "Who is MoSenSo Digital Marketing?"
        let divider = createElement "div"
        divider.className <- "divider"
        let aboutDescription = createElement "p"
        aboutDescription.textContent <- "We are a forward-thinking digital marketing agency dedicated to helping brands navigate the digital landscape. With a mix of creativity and analytics, we ensure your message reaches the right audience and drives measurable results."
        let aboutList = createElement "ul"
        aboutList.className <- "about-list"
        let listItems = [
            "Data-Driven Strategies"
            "Transparent Reporting"
            "ROI-Focused Campaigns"
        ]
        for itemText in listItems do
            let row = createElement "li"
            let icon = createElement "i"
            icon.className <- "fa-solid fa-check-circle"
            let label = createElement "span"
            label.textContent <- itemText
            row.appendChild icon |> ignore
            row.appendChild label |> ignore
            aboutList.appendChild row |> ignore

        aboutText.appendChild aboutTitle |> ignore
        aboutText.appendChild divider |> ignore
        aboutText.appendChild aboutDescription |> ignore
        aboutText.appendChild aboutList |> ignore

        let aboutImage = createElement "div"
        aboutImage.className <- "about-image"
        let image = createElement "img" :?> HTMLImageElement
        image.src <- "https://images.unsplash.com/photo-1552664730-d307ca884978?auto=format&fit=crop&w=800&q=80"
        image.alt <- "Team collaborating"
        aboutImage.appendChild image |> ignore

        about.appendChild aboutText |> ignore
        about.appendChild aboutImage |> ignore

        let services = createElement "section"
        services.id <- "services"
        services.className <- "services-section"
        let servicesContainer = createElement "div"
        servicesContainer.className <- "container text-center"
        let servicesTitle = createElement "h2"
        servicesTitle.textContent <- "Our Core Services"
        let servicesDivider = createElement "div"
        servicesDivider.className <- "divider center"
        let subtitle = createElement "p"
        subtitle.className <- "section-subtitle"
        subtitle.textContent <- "Comprehensive solutions to scale your business online."
        let servicesGrid = createElement "div"
        servicesGrid.className <- "services-grid"

        let serviceItems = [
            ("SEO Optimization", "Dominate search engine rankings and drive organic, high-quality traffic to your website.", "fa-solid fa-magnifying-glass-chart")
            ("Social Media Marketing", "Build a loyal community and boost brand awareness across Facebook, Instagram, and LinkedIn.", "fa-solid fa-hashtag")
            ("Content Strategy", "Engage your audience with compelling articles, videos, and graphics that tell your brand's story.", "fa-solid fa-pen-nib")
            ("PPC Advertising", "Maximize your ROI with targeted Google and Social Media ad campaigns.", "fa-solid fa-bullhorn")
        ]

        for (titleText, descriptionText, iconClass) in serviceItems do
            let card = createElement "div"
            card.className <- "service-card"
            let iconWrap = createElement "div"
            iconWrap.className <- "icon"
            let icon = createElement "i"
            icon.className <- iconClass
            let cardTitle = createElement "h3"
            cardTitle.textContent <- titleText
            let cardText = createElement "p"
            cardText.textContent <- descriptionText
            iconWrap.appendChild icon |> ignore
            card.appendChild iconWrap |> ignore
            card.appendChild cardTitle |> ignore
            card.appendChild cardText |> ignore
            servicesGrid.appendChild card |> ignore

        servicesContainer.appendChild servicesTitle |> ignore
        servicesContainer.appendChild servicesDivider |> ignore
        servicesContainer.appendChild subtitle |> ignore
        servicesContainer.appendChild servicesGrid |> ignore
        services.appendChild servicesContainer |> ignore

        let contact = createElement "section"
        contact.id <- "contact"
        contact.className <- "contact container"

        let contactInfo = createElement "div"
        contactInfo.className <- "contact-info"
        let contactTitle = createElement "h2"
        contactTitle.textContent <- "Let's Talk Growth"
        let contactDivider = createElement "div"
        contactDivider.className <- "divider"
        let contactText = createElement "p"
        contactText.textContent <- "Ready to take your business to the next level? Reach out to us today and let's discuss your digital strategy."
        let infoItems = [
            ("fa-solid fa-envelope", "hello@mosensodigitalmarketing.com")
            ("fa-solid fa-phone", "+255 746 861 651")
            ("fa-solid fa-location-dot", "Arusha, Tanzania")
        ]
        for (iconClass, valueText) in infoItems do
            let item = createElement "div"
            item.className <- "info-item"
            let icon = createElement "i"
            icon.className <- iconClass
            let text = createElement "span"
            text.textContent <- valueText
            item.appendChild icon |> ignore
            item.appendChild text |> ignore
            contactInfo.appendChild item |> ignore

        contactInfo.appendChild contactTitle |> ignore
        contactInfo.appendChild contactDivider |> ignore
        contactInfo.appendChild contactText |> ignore

        let form = createElement "form"
        form.className <- "contact-form"
        form.setAttribute("action", "https://formspree.io/f/mkoladgz")
        form.setAttribute("method", "POST")

        let nameInput = createElement "input" :?> HTMLInputElement
        nameInput.setAttribute("type", "text")
        nameInput.setAttribute("placeholder", "Your Name")
        nameInput.setAttribute("required", "required")

        let emailInput = createElement "input" :?> HTMLInputElement
        emailInput.setAttribute("type", "email")
        emailInput.setAttribute("placeholder", "Your Email")
        emailInput.setAttribute("required", "required")

        let select = createElement "select"
        let optionDefault = createElement "option"
        optionDefault.setAttribute("value", "")
        optionDefault.textContent <- "Interested Service..."
        let optionSeo = createElement "option"
        optionSeo.setAttribute("value", "seo")
        optionSeo.textContent <- "SEO"
        let optionSocial = createElement "option"
        optionSocial.setAttribute("value", "social")
        optionSocial.textContent <- "Social Media"
        let optionAds = createElement "option"
        optionAds.setAttribute("value", "ads")
        optionAds.textContent <- "Paid Ads"
        select.appendChild optionDefault |> ignore
        select.appendChild optionSeo |> ignore
        select.appendChild optionSocial |> ignore
        select.appendChild optionAds |> ignore

        let textarea = createElement "textarea"
        textarea.setAttribute("rows", "5")
        textarea.setAttribute("placeholder", "Tell us about your project")
        textarea.setAttribute("required", "required")

        let button = createElement "button"
        button.className <- "btn btn-primary"
        button.setAttribute("type", "submit")
        button.textContent <- "Send Message"

        form.appendChild nameInput |> ignore
        form.appendChild emailInput |> ignore
        form.appendChild select |> ignore
        form.appendChild textarea |> ignore
        form.appendChild button |> ignore

        contact.appendChild contactInfo |> ignore
        contact.appendChild form |> ignore

        let footer = createElement "footer"
        let footerContent = createElement "div"
        footerContent.className <- "container footer-content"
        let footerLogo = createElement "div"
        footerLogo.className <- "footer-logo"
        footerLogo.innerHTML <- "<i class=\"fa-solid fa-chart-pie\"></i> MoSenSo<span>Digital<span>Marketing</span>"

        let socialLinks = createElement "div"
        socialLinks.className <- "social-links"
        let linkedIn = createIconButton "fa-brands fa-linkedin" "#"
        let twitter = createIconButton "fa-brands fa-twitter" "#"
        let instagram = createIconButton "fa-brands fa-instagram" "https://www.instagram.com/mosenso_digital_marketing?igsh=YXdjMm10NzJsZDB0"
        let facebook = createIconButton "fa-brands fa-facebook" "#"
        socialLinks.appendChild linkedIn |> ignore
        socialLinks.appendChild twitter |> ignore
        socialLinks.appendChild instagram |> ignore
        socialLinks.appendChild facebook |> ignore

        footerContent.appendChild footerLogo |> ignore
        footerContent.appendChild socialLinks |> ignore

        let footerBottom = createElement "div"
        footerBottom.className <- "footer-bottom"
        let footerCopy = createElement "p"
        footerCopy.textContent <- "© 2026 MoSenSo Digital Marketing. All rights reserved."
        footerBottom.appendChild footerCopy |> ignore

        footer.appendChild footerContent |> ignore
        footer.appendChild footerBottom |> ignore

        root.appendChild header |> ignore
        root.appendChild home |> ignore
        root.appendChild about |> ignore
        root.appendChild services |> ignore
        root.appendChild contact |> ignore
        root.appendChild footer |> ignore

let attachInteractions () =
    let header = document.getElementById "header"
    let menuToggle = document.querySelector ".menu-toggle"
    let navLinks = document.querySelector ".nav-links"
    let navAnchors = document.querySelectorAll ".nav-links a"

    if not (isNull menuToggle) && not (isNull navLinks) then
        menuToggle.addEventListener("click", fun _ ->
            navLinks.classList.toggle("open") |> ignore
        )

    for index = 0 to navAnchors.length - 1 do
        let anchor = navAnchors.item index
        if not (isNull anchor) then
            anchor.addEventListener("click", fun _ ->
                if not (isNull navLinks) then
                    navLinks.classList.remove("open") |> ignore
            )

    window.addEventListener("scroll", fun _ ->
        if not (isNull header) then
            if window.scrollY > 12.0 then
                header.style.boxShadow <- "0 8px 24px rgba(0, 0, 0, 0.28)"
            else
                header.style.boxShadow <- "none"
    )

    let contactForm = document.querySelector ".contact-form"
    if not (isNull contactForm) then
        let status = document.createElement "p"
        status.className <- "form-status"
        status.setAttribute("aria-live", "polite")
        contactForm.appendChild status |> ignore
        contactForm.addEventListener("submit", fun event ->
            event.preventDefault()
            status.textContent <- "Message sent successfully. We will contact you soon."
            contactForm.reset()
        )

renderSite ()
attachInteractions ()
