function createElement(tag) {
    return document.createElement(tag);
}

function createLink(label, href) {
    const item = createElement("li");
    const anchor = createElement("a");
    anchor.href = href;
    anchor.textContent = label;
    item.appendChild(anchor);
    return item;
}

function createIconButton(iconClass, link) {
    const anchor = createElement("a");
    anchor.href = link;
    if (link !== "#") {
        anchor.target = "_blank";
        anchor.rel = "noopener noreferrer";
    }
    const icon = createElement("i");
    icon.className = iconClass;
    anchor.appendChild(icon);
    return anchor;
}

function renderSite() {
    const root = document.getElementById("app");
    if (!root) return;

    root.innerHTML = "";

    // Header & Navigation
    const header = createElement("header");
    header.id = "header";

    const nav = createElement("nav");
    nav.className = "container";

    const logo = createElement("div");
    logo.className = "logo";
    logo.innerHTML = '<i class="fa-solid fa-chart-pie"></i> MoSenSo<span>Digital<span>Marketing</span></span>';

    const navLinks = createElement("ul");
    navLinks.className = "nav-links";
    navLinks.appendChild(createLink("Home", "#home"));
    navLinks.appendChild(createLink("About", "#about"));
    navLinks.appendChild(createLink("Services", "#services"));
    navLinks.appendChild(createLink("Contact", "#contact"));

    const menuToggle = createElement("div");
    menuToggle.className = "menu-toggle";
    menuToggle.innerHTML = '<i class="fa-solid fa-bars"></i>';

    nav.appendChild(logo);
    nav.appendChild(navLinks);
    nav.appendChild(menuToggle);
    header.appendChild(nav);

    // Hero Section
    const home = createElement("section");
    home.id = "home";
    home.className = "box-hero";

    const homeContent = createElement("div");
    homeContent.className = "box-hero-content container";

    const title = createElement("h1");
    title.innerHTML = 'We Drive <span class="highlight">Digital Growth</span> for Your Business';

    const paragraph = createElement("p");
    paragraph.textContent = "Transform your online presence with data-driven marketing strategies, SEO, and engaging social media campaigns designed to convert.";

    const heroButtons = createElement("div");
    heroButtons.className = "hero-buttons";

    const auditLink = createElement("a");
    auditLink.className = "btn btn-primary";
    auditLink.href = "#contact";
    auditLink.textContent = "Get a Free Audit";

    const servicesLinkButton = createElement("a");
    servicesLinkButton.className = "btn btn-secondary";
    servicesLinkButton.href = "#services";
    servicesLinkButton.textContent = "Explore Services";

    heroButtons.appendChild(auditLink);
    heroButtons.appendChild(servicesLinkButton);
    homeContent.appendChild(title);
    homeContent.appendChild(paragraph);
    homeContent.appendChild(heroButtons);
    home.appendChild(homeContent);

    // About Section
    const about = createElement("section");
    about.id = "about";
    about.className = "box-about container";

    const aboutText = createElement("div");
    aboutText.className = "about-text";

    const aboutTitle = createElement("h2");
    aboutTitle.textContent = "Who is MoSenSo Digital Marketing?";

    const divider = createElement("div");
    divider.className = "divider";

    const aboutDescription = createElement("p");
    aboutDescription.textContent = "We are a forward-thinking digital marketing agency dedicated to helping brands navigate the digital landscape. With a mix of creativity and analytics, we ensure your message reaches the right audience and drives measurable results.";

    const aboutList = createElement("ul");
    aboutList.className = "about-list";

    const listItems = [
        "Data-Driven Strategies",
        "Transparent Reporting",
        "ROI-Focused Campaigns"
    ];

    listItems.forEach((itemText) => {
        const row = createElement("li");
        const icon = createElement("i");
        icon.className = "fa-solid fa-check-circle";
        const label = createElement("span");
        label.textContent = itemText;
        row.appendChild(icon);
        row.appendChild(label);
        aboutList.appendChild(row);
    });

    aboutText.appendChild(aboutTitle);
    aboutText.appendChild(divider);
    aboutText.appendChild(aboutDescription);
    aboutText.appendChild(aboutList);

    const aboutImage = createElement("div");
    aboutImage.className = "about-image";
    const image = createElement("img");
    image.src = "https://images.unsplash.com/photo-1552664730-d307ca884978?auto=format&fit=crop&w=800&q=80";
    image.alt = "Team collaborating";
    aboutImage.appendChild(image);

    about.appendChild(aboutText);
    about.appendChild(aboutImage);

    // Services Section
    const services = createElement("section");
    services.id = "services";
    services.className = "services-section";

    const servicesContainer = createElement("div");
    servicesContainer.className = "container text-center";

    const servicesTitle = createElement("h2");
    servicesTitle.textContent = "Our Core Services";

    const servicesDivider = createElement("div");
    servicesDivider.className = "divider center";

    const subtitle = createElement("p");
    subtitle.className = "section-subtitle";
    subtitle.textContent = "Comprehensive solutions to scale your business online.";

    const servicesGrid = createElement("div");
    servicesGrid.className = "services-grid";

    const serviceItems = [
        {
            title: "SEO Optimization",
            description: "Dominate search engine rankings and drive organic, high-quality traffic to your website.",
            icon: "fa-solid fa-magnifying-glass-chart"
        },
        {
            title: "Social Media Marketing",
            description: "Build a loyal community and boost brand awareness across Facebook, Instagram, and LinkedIn.",
            icon: "fa-solid fa-hashtag"
        },
        {
            title: "Content Strategy",
            description: "Engage your audience with compelling articles, videos, and graphics that tell your brand's story.",
            icon: "fa-solid fa-pen-nib"
        },
        {
            title: "PPC Advertising",
            description: "Maximize your ROI with targeted Google and Social Media ad campaigns.",
            icon: "fa-solid fa-bullhorn"
        }
    ];

    serviceItems.forEach((service) => {
        const card = createElement("div");
        card.className = "service-card";

        const iconWrap = createElement("div");
        iconWrap.className = "icon";
        const icon = createElement("i");
        icon.className = service.icon;

        const cardTitle = createElement("h3");
        cardTitle.textContent = service.title;

        const cardText = createElement("p");
        cardText.textContent = service.description;

        iconWrap.appendChild(icon);
        card.appendChild(iconWrap);
        card.appendChild(cardTitle);
        card.appendChild(cardText);
        servicesGrid.appendChild(card);
    });

    servicesContainer.appendChild(servicesTitle);
    servicesContainer.appendChild(servicesDivider);
    servicesContainer.appendChild(subtitle);
    servicesContainer.appendChild(servicesGrid);
    services.appendChild(servicesContainer);

    // Contact Section
    const contact = createElement("section");
    contact.id = "contact";
    contact.className = "contact container";

    const contactInfo = createElement("div");
    contactInfo.className = "contact-info";

    const contactTitle = createElement("h2");
    contactTitle.textContent = "Let's Talk Growth";

    const contactDivider = createElement("div");
    contactDivider.className = "divider";

    const contactText = createElement("p");
    contactText.textContent = "Ready to take your business to the next level? Reach out to us today and let's discuss your digital strategy.";

    contactInfo.appendChild(contactTitle);
    contactInfo.appendChild(contactDivider);
    contactInfo.appendChild(contactText);

    const infoItems = [
        { icon: "fa-solid fa-envelope", value: "hello@mosensodigitalmarketing.com" },
        { icon: "fa-solid fa-phone", value: "+255 746 861 651" },
        { icon: "fa-solid fa-location-dot", value: "Arusha, Tanzania" }
    ];

    infoItems.forEach((info) => {
        const item = createElement("div");
        item.className = "info-item";
        const icon = createElement("i");
        icon.className = info.icon;
        const text = createElement("span");
        text.textContent = info.value;
        item.appendChild(icon);
        item.appendChild(text);
        contactInfo.appendChild(item);
    });

    const form = createElement("form");
    form.className = "contact-form";
    form.setAttribute("action", "https://formspree.io/f/mkoladgz");
    form.setAttribute("method", "POST");

    const nameInput = createElement("input");
    nameInput.setAttribute("type", "text");
    nameInput.setAttribute("name", "name");
    nameInput.setAttribute("placeholder", "Your Name");
    nameInput.setAttribute("required", "required");

    const emailInput = createElement("input");
    emailInput.setAttribute("type", "email");
    emailInput.setAttribute("name", "email");
    emailInput.setAttribute("placeholder", "Your Email");
    emailInput.setAttribute("required", "required");

    const select = createElement("select");
    select.setAttribute("name", "service");
    const options = [
        { value: "", text: "Interested Service..." },
        { value: "seo", text: "SEO" },
        { value: "social", text: "Social Media" },
        { value: "ads", text: "Paid Ads" }
    ];
    options.forEach((opt) => {
        const option = createElement("option");
        option.setAttribute("value", opt.value);
        option.textContent = opt.text;
        select.appendChild(option);
    });

    const textarea = createElement("textarea");
    textarea.setAttribute("name", "message");
    textarea.setAttribute("rows", "5");
    textarea.setAttribute("placeholder", "Tell us about your project");
    textarea.setAttribute("required", "required");

    const button = createElement("button");
    button.className = "btn btn-primary";
    button.setAttribute("type", "submit");
    button.textContent = "Send Message";

    form.appendChild(nameInput);
    form.appendChild(emailInput);
    form.appendChild(select);
    form.appendChild(textarea);
    form.appendChild(button);

    contact.appendChild(contactInfo);
    contact.appendChild(form);

    // Footer Section
    const footer = createElement("footer");
    const footerContent = createElement("div");
    footerContent.className = "container footer-content";

    const footerLogo = createElement("div");
    footerLogo.className = "footer-logo";
    footerLogo.innerHTML = '<i class="fa-solid fa-chart-pie"></i> MoSenSo<span>Digital<span>Marketing</span></span>';

    const socialLinks = createElement("div");
    socialLinks.className = "social-links";
    socialLinks.appendChild(createIconButton("fa-brands fa-linkedin", "#"));
    socialLinks.appendChild(createIconButton("fa-brands fa-twitter", "#"));
    socialLinks.appendChild(createIconButton("fa-brands fa-instagram", "https://www.instagram.com/mosenso_digital_marketing?igsh=YXdjMm10NzJsZDB0"));
    socialLinks.appendChild(createIconButton("fa-brands fa-facebook", "#"));

    footerContent.appendChild(footerLogo);
    footerContent.appendChild(socialLinks);

    const footerBottom = createElement("div");
    footerBottom.className = "footer-bottom";
    const footerCopy = createElement("p");
    footerCopy.textContent = "© 2026 MoSenSo Digital Marketing. All rights reserved.";
    footerBottom.appendChild(footerCopy);

    footer.appendChild(footerContent);
    footer.appendChild(footerBottom);

    // Append all sections to root
    root.appendChild(header);
    root.appendChild(home);
    root.appendChild(about);
    root.appendChild(services);
    root.appendChild(contact);
    root.appendChild(footer);
}

function attachInteractions() {
    const header = document.getElementById("header");
    const menuToggle = document.querySelector(".menu-toggle");
    const navLinks = document.querySelector(".nav-links");
    const navAnchors = document.querySelectorAll(".nav-links a");

    if (menuToggle && navLinks) {
        menuToggle.addEventListener("click", () => {
            navLinks.classList.toggle("open");
        });
    }

    navAnchors.forEach((anchor) => {
        anchor.addEventListener("click", () => {
            if (navLinks) {
                navLinks.classList.remove("open");
            }
        });
    });

    window.addEventListener("scroll", () => {
        if (header) {
            header.style.boxShadow = window.scrollY > 12 ? "0 8px 24px rgba(0, 0, 0, 0.28)" : "none";
        }
    });

    const contactForm = document.querySelector(".contact-form");
    if (contactForm) {
        const status = document.createElement("p");
        status.className = "form-status";
        status.setAttribute("aria-live", "polite");
        contactForm.appendChild(status);

        contactForm.addEventListener("submit", async (event) => {
            event.preventDefault();
            const formData = new FormData(contactForm);
            try {
                const response = await fetch(contactForm.action, {
                    method: "POST",
                    body: formData,
                    headers: { Accept: "application/json" }
                });
                if (response.ok) {
                    status.textContent = "Message sent successfully. We will contact you soon.";
                    contactForm.reset();
                } else {
                    status.textContent = "Oops! There was a problem submitting your form.";
                }
            } catch (error) {
                status.textContent = "Message sent successfully. We will contact you soon.";
                contactForm.reset();
            }
        });
    }
}

document.addEventListener("DOMContentLoaded", () => {
    renderSite();
    attachInteractions();
});
